using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace cross2
{
   public class THINK
    {
        int[,] statusMatrix;        //状态数组
        int[,] weightMatrix;        //权值数组

        public THINK()
        {
            statusMatrix = new int[3, 3];
            weightMatrix = new int[3, 3];

            for (int i = 0; i < 3; i++)        
                for (int j = 0; j < 3; j++)
                {
                    statusMatrix[i, j] = 0;        //表示棋盘该位置当前无子
                    weightMatrix[i, j] = -1;       //表示无下子倾向
                }
        }

        public int[,] getNextStep(int[,] inputMatrix)
        {
            int maxWeight = 0;   //假设权值最大值为maxweight,便于计算权值最大的位置
            List<int> positionPool = new List<int>();       //List是一个容器类，里面装的都是类的对象
            int positionPicked = 0;     //记录权值相等的位置

            THINK chess = new THINK();
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    statusMatrix[i, j] = inputMatrix[i, j];
            if (chess.checkFinished(statusMatrix) == 10)   //玩家已赢，电脑无需再下
                return statusMatrix;

            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    
                    //由于棋盘上还没有落子，当statusMatrix[i, j] == 0即棋盘为空的时候， weightMatrix[i,j] = 0。
                    if (statusMatrix[i, j] == 0)
                    {
                        weightMatrix[i,j] = 0;

                        //第一种情况：杀                    
                        if (statusMatrix[i, 0] + statusMatrix[i, 1] + statusMatrix[i, 2] == 2)
                            weightMatrix[i, j] += 10000;        //表示在棋盘上横向的直线上有两个电脑的棋子

                        if (statusMatrix[0, j] + statusMatrix[1, j] + statusMatrix[2, j] == 2)
                            weightMatrix[i, j] += 10000;        //表示在棋盘上纵向的直线上有两个电脑的棋子

                        if (i == j && statusMatrix[0, 0] + statusMatrix[1, 1] + statusMatrix[2, 2] == 2)
                            weightMatrix[i, j] += 10000;        //表示在棋盘上正对角线上有两个电脑的棋子

                        if (i + j == 2 && statusMatrix[0, 2] + statusMatrix[1, 1] + statusMatrix[2, 0] == 2)
                            weightMatrix[i, j] += 10000;        //表示在棋盘上另一对角线上有两个电脑的棋子

                        //第二种情况：堵                     
                        if (statusMatrix[i, 0] + statusMatrix[i, 1] + statusMatrix[i, 2] == 20)
                            weightMatrix[i, j] += 1000;         //表示在棋盘上横向的直线上有两个玩家的棋子

                        if (statusMatrix[0, j] + statusMatrix[1, j] + statusMatrix[2, j] == 20)
                            weightMatrix[i, j] += 1000;

                        if (i == j && statusMatrix[0, 0] + statusMatrix[1, 1] + statusMatrix[2, 2] == 20)
                            weightMatrix[i, j] += 1000;

                        if (i + j == 2 && statusMatrix[0, 2] + statusMatrix[1, 1] + statusMatrix[2, 0] == 20)
                            weightMatrix[i, j] += 1000;

                        //第三种情况：中心点（电脑优先选择中心有利位置）
                        if (i == 1 && j == 1)
                            weightMatrix[i, j] += 400;

                        //第四种情况：占角点（角点也是有利位置）                        
                        if (i + j == 2 && i != j)
                            weightMatrix[i, j] += 300;
                        if (i == j && i != 1)
                            weightMatrix[i, j] += 300;

                        //冲二
                        if (statusMatrix[i, 0] + statusMatrix[i, 1] + statusMatrix[i, 2] == 2)
                            weightMatrix[i, j] += 1;
                        if (statusMatrix[0, j] + statusMatrix[1, j] + statusMatrix[2, j] == 2)
                            weightMatrix[i, j] += 1;
                        if (i == j && statusMatrix[0, 0] + statusMatrix[1, 1] + statusMatrix[2, 2] == 2)
                            weightMatrix[i, j] += 1;
                        if (i + j == 2 && statusMatrix[0, 2] + statusMatrix[1, 1] + statusMatrix[2, 0] == 2)
                            weightMatrix[i, j] += 1;

                        //特殊情况
                        //当[0, 0]和 [2, 2]位置上的棋子为对弈者的棋子时，在[0, 2]和 [2, 0]位置上的权值会相对减少
                        if (statusMatrix[0, 0] + statusMatrix[2, 2] == 20)
                        {
                            weightMatrix[0, 2] -= 500;
                            weightMatrix[2, 0] -= 500;
                        }
                        if (statusMatrix[2, 0] + statusMatrix[0, 2] == 20)
                        {
                            weightMatrix[0, 0] -= 500;
                            weightMatrix[2, 2] -= 500;
                        }
                    }

            //计算最大权值
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    if (weightMatrix[i, j] >= maxWeight)
                        maxWeight = weightMatrix[i, j];

           
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    if (weightMatrix[i, j] == maxWeight)
                        positionPool.Add(i * 3 + j);

            if (positionPool.Count != 0)
            {
                positionPicked = positionPool[RandomInt(positionPool.Count)];
                statusMatrix[positionPicked / 3, positionPicked % 3] = 1;    //计算思想来源于i * 3 + j  确定随机位置
            }
            return statusMatrix;
        }

        public int[,] getNextStep_simple(int[,] inputMatrix)
        {

            int maxWeight = 0;
            List<int> positionPool = new List<int>();       //List是一个容器类，里面装的都是类的对象
            int positionPicked = 0;

            THINK chess = new THINK();
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    statusMatrix[i, j] = inputMatrix[i, j];
            if (chess.checkFinished(statusMatrix) == 10)   //玩家已赢，电脑无需再下
                return statusMatrix;

            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)

                    //由于棋盘上还没有落子，当statusMatrix[i, j] == 0即棋盘为空的时候， weightMatrix[i,j] = 0。
                    if (statusMatrix[i, j] == 0)
                    {
                        weightMatrix[i, j] = 0;
                        
                        //“新手上路”电脑只会判断一种情况：杀
                        if (statusMatrix[i, 0] + statusMatrix[i, 1] + statusMatrix[i, 2] == 2)
                            weightMatrix[i, j] += 10000;        //表示在棋盘上横向的直线上有两个电脑的棋子

                        if (statusMatrix[0, j] + statusMatrix[1, j] + statusMatrix[2, j] == 2)
                            weightMatrix[i, j] += 10000;        //表示在棋盘上纵向的直线上有两个电脑的棋子

                        if (i == j && statusMatrix[0, 0] + statusMatrix[1, 1] + statusMatrix[2, 2] == 2)
                            weightMatrix[i, j] += 10000;        //表示在棋盘上正对角线上有两个电脑的棋子

                        if (i + j == 2 && statusMatrix[0, 2] + statusMatrix[1, 1] + statusMatrix[2, 0] == 2)
                            weightMatrix[i, j] += 10000;        //表示在棋盘上另一对角线上有两个电脑的棋子

                    }

            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    if (weightMatrix[i, j] >= maxWeight)
                        maxWeight = weightMatrix[i, j];

            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    if (weightMatrix[i, j] == maxWeight)
                        positionPool.Add(i * 3 + j);

            if (positionPool.Count != 0)
            {
                positionPicked = positionPool[RandomInt(positionPool.Count)];
                statusMatrix[positionPicked / 3, positionPicked % 3] = 1;
            }
            return statusMatrix;
        }

        private int RandomInt(int max)
        {
            int result;
            Random rd = new Random();           //对于同样的对弈者的布局，使用Random会使电脑下出不同的方案
            result = rd.Next(max);
            return result;
        }

        public int checkFinished(int[,] statusMatrix)
        {
            int result = 0;

            //电脑赢
            for (int i = 0; i < 3; i++)
                if (statusMatrix[i, 0] + statusMatrix[i, 1] + statusMatrix[i, 2] == 3)
                    result = 1;
            for (int j = 0; j < 3; j++)
                if (statusMatrix[0, j] + statusMatrix[1, j] + statusMatrix[2, j] == 3)
                    result = 1;
            if (statusMatrix[0, 0] + statusMatrix[1, 1] + statusMatrix[2, 2] == 3)
                result = 1;
            if (statusMatrix[0, 2] + statusMatrix[1, 1] + statusMatrix[2, 0] == 3)
                result = 1;

            //玩家赢
            for (int i = 0; i < 3; i++)
                if (statusMatrix[i, 0] + statusMatrix[i, 1] + statusMatrix[i, 2] == 30)
                    result = 10;
            for (int j = 0; j < 3; j++)
                if (statusMatrix[0, j] + statusMatrix[1, j] + statusMatrix[2, j] == 30)
                    result = 10;
            if (statusMatrix[0, 0] + statusMatrix[1, 1] + statusMatrix[2, 2] == 30)
                result = 10;
            if (statusMatrix[0, 2] + statusMatrix[1, 1] + statusMatrix[2, 0] == 30)
                result = 10;
           
            //打平
            int blank = 0;
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    if (statusMatrix[i, j] == 0)
                        blank++;
                    if (result == 0 && blank == 0)
                        result = 100;

            return result;
        }
    }
}
