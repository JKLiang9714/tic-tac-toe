using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using cross2; 

namespace cross2
{
    public partial class Form1 : Form
    {
        private int[,] statusMatrix;        //棋盘上的状态，0为无子，1为电脑下子，10为玩家下子
        bool finished;
        bool Computerfirst;
        bool difficulty;
        int flag;  //新手上路、专业玩家的标志：0表示没选，1表示新手上路，2表示专业玩家
        bool begin;   //是否点击开始游戏
        int count;    //点击“开始游戏”的次数
        bool log;   //判断用户是否登录


        public Form1()
        {
            InitializeComponent();
            string strFileName = "data.txt";
            if (File.Exists(strFileName))   //判断文件是否存在
                File.Delete("data.txt");
            statusMatrix = new int[3, 3];
            initializeGame();           //初始化游戏
            Computerfirst = false;      //初始化玩家先手
            flag = 0;   //默认是没选难度
            difficulty = false;         //初始化难度为“新手上路”
            begin = false;
            count = 0;    //没点“开始游戏”
            log = false;   //初始化用户为未登录状态
        }

        public void initializeGame()
        {
            resetMatrix();          //初始化3*3的格子均为“无子”状态
            finished = false;
            initializeDisplay();        //初始化棋盘
        }

        private void resetMatrix()
        {
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    statusMatrix[i, j] = 0;         
        }

        private void initializeDisplay()
        {
            pictureBox1.BackgroundImage = new Bitmap("TABLE.jpg");
            Bitmap mainGround = new Bitmap(300, 300);
            Graphics g;
            g = Graphics.FromImage(mainGround);
            pictureBox1.Image = mainGround;
        }

        private void displayChess()
        {   
            Bitmap mainGround = new Bitmap(300, 300);
            Graphics g;
            g = Graphics.FromImage(mainGround);
            Pen p1 = new Pen(Color.WhiteSmoke, 4);        //表示电脑的棋子的颜色和宽度
            Pen p2 = new Pen(Color.WhiteSmoke, 4);         //表示人的棋子的颜色和宽度

            //DrawEllipse(Pen,Single,Single,Height,Width)表示绘制一个由边框定义（该边框由一对坐标、高度和宽度制定）的椭圆（此地可用作圆）
            //在棋盘上，i表示行，j表示列，用i、j表示棋子落子的位置
            //在对落子的确切位置和轮到谁落子确定后，可以在棋盘的每个格子上准确的显示出应该出现的棋子 
           
            for (int i = 0; i < 3;i++ )
                for (int j = 0; j < 3; j++)
                {
                    if (statusMatrix[i, j] == 1)        //如果电脑下子，要下的格子就会出现如下代码表示的O
                        g.DrawEllipse(p1, i * 100 + 8, 300 - j * 100 - 80 - 10, 75, 75);
                    if (statusMatrix[i, j] == 10)       //如果轮到人下子，只有鼠标点击到的格子，就会出现如下代码所示的X
                    {
                        g.DrawLine(p2, new Point(i * 100 + 9, 300 - j * 100 - 12), new Point(i * 100 + 84, 300 - j * 100 - 87)); //画'/'
                        g.DrawLine(p2, new Point(i * 100 + 9, 300 - j * 100 - 87), new Point(i * 100 + 84, 300 - j * 100 - 12)); //画'\'
                    }
                }
             pictureBox1.Image = mainGround;
        }

        public void toNextStep()
        {
            THINK chess = new THINK();
            statusMatrix = chess.getNextStep(statusMatrix);   //玩家下完之后的棋盘，判断电脑的操作：下子/已输
            int gameresult = chess.checkFinished(statusMatrix);
            switch (gameresult)
            {
                case 1:
                    finished = true;
                    using (StreamWriter file = new StreamWriter("data.txt", true))  //将文本追加到现有文件data.txt
                    {
                        file.WriteLine("--" + DateTime.Now.ToString() + "  您输给了电脑！");   //拼接到一行
                        file.Close();
                        file.Dispose();
                    }
                    label3.Text = "游戏结束，电脑赢了！";
                    break;
                case 10:
                    finished = true;
                    using (StreamWriter file = new StreamWriter("data.txt", true))  //将文本追加到现有文件data.txt
                    {
                        file.WriteLine("--" + DateTime.Now.ToString() + "  电脑输给了您！");  //拼接到一行
                        file.Close();
                        file.Dispose();
                    }
                    label3.Text = "游戏结束，你赢了！";
                    break;
                case 100:
                    finished = true;
                    using (StreamWriter file = new StreamWriter("data.txt", true))  //将文本追加到现有文件data.txt
                    {
                        file.WriteLine("--" + DateTime.Now.ToString() + "  您与电脑打成了平局！");    //拼接到一行
                        file.Close();
                        file.Dispose();
                    }
                    label3.Text = "游戏结束，打成平手！";
                    break;
                default:
                    finished = false;
                    label3.Text = "      请下子";
                    break;
            }
        }

        public void toNextStep_simple()
        {
            THINK chess = new THINK();
            statusMatrix = chess.getNextStep_simple(statusMatrix);   //玩家下完之后的棋盘，判断电脑的操作：下子/已输
            int gameresult = chess.checkFinished(statusMatrix);
            switch (gameresult)
            {
                case 1:
                    finished = true;
                    using (StreamWriter file = new StreamWriter("data.txt", true))  //将文本追加到现有文件data.txt
                    {
                        file.WriteLine("--" + DateTime.Now.ToString() + "  您输给了电脑！");   //拼接到一行
                        file.Close();
                        file.Dispose();
                    }
                    label3.Text = "游戏结束，电脑赢了！";
                    break;
                case 10:
                    finished = true;
                    using (StreamWriter file = new StreamWriter("data.txt", true))  //将文本追加到现有文件data.txt
                    {
                        file.WriteLine("--" + DateTime.Now.ToString() + "  电脑输给了您！");   //拼接到一行
                        file.Close();
                        file.Dispose();
                    }
                    label3.Text = "游戏结束，你赢了！";
                    break;
                case 100:
                    finished = true;
                    using (StreamWriter file = new StreamWriter("data.txt", true))  //将文本追加到现有文件data.txt
                    {
                        file.WriteLine("--" + DateTime.Now.ToString() + "  您与电脑打成了平局！");  //拼接到一行
                        file.Close();
                        file.Dispose();
                    }
                    label3.Text = "游戏结束，打成平手！";
                    break;
                default:
                    finished = false;
                    label3.Text = "      请下子";
                    break;
            }
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (!finished && begin)   //点击了“开始游戏”且游戏未结束
            {
                int positionX = e.X / 100;
                int positionY = (300 - e.Y) / 100;
                if (statusMatrix[positionX, positionY] == 0)
                {
                    statusMatrix[positionX, positionY] = 10;
                    if (difficulty)
                        toNextStep();
                    else
                        toNextStep_simple();
                    displayChess();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            initializeGame();
            count++;
            begin = true;
            label3.Text = "      请下子";
            if (!log && count == 1)    //用户未登录且点击一次“开始游戏”
            {
                using (StreamWriter file = new StreamWriter("data.txt", true))  //将文本追加到现有文件data.txt
                {
                    file.WriteLine("您当前为游客身份");
                    file.Close();
                    file.Dispose();
                }
            }
            if (flag == 0 && count == 1)   //仅在第一次点击“开始游戏”且没选难度时执行
            {
                using (StreamWriter file = new StreamWriter("data.txt", true))  //将文本追加到现有文件data.txt
                {
                    file.WriteLine("系统默认您选择了新手上路：");
                    file.Close();
                    file.Dispose();
                }
            }
            if (Computerfirst)
            {
                if (difficulty)
                    toNextStep();
                else
                    toNextStep_simple();
                displayChess();
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Computerfirst = false;          //玩家先手
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Computerfirst = true;           //电脑先手
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        private void 井字棋规则介绍ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.StartPosition = FormStartPosition.CenterScreen;         //窗口初始化在屏幕正中间
            frm.Show();         //show()函数表明制定窗口显示状态，在这里表明Form2在窗口中显示
        }

        private void 新手上路ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            difficulty = false;
            flag = 1;   //已选择“新手上路”
            initializeGame();
            using (StreamWriter file = new StreamWriter("data.txt", true))  //将文本追加到现有文件data.txt
            {
                file.WriteLine("您选择了新手上路：");
                file.Close();
                file.Dispose();
            }
            if (Computerfirst)//表明如果电脑先手，那么电脑就会根据之前的走法选择最有利于电脑本身的走法             
            {
                if (difficulty)
                    toNextStep();
                else
                    toNextStep_simple();
                displayChess();
            }
        }

        private void 专业玩家ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            difficulty = true;
            flag = 2;    //已选择“专业玩家”
            initializeGame();
            using (StreamWriter file = new StreamWriter("data.txt", true))  //将文本追加到现有文件data.txt
            {
                file.WriteLine("您选择了专业玩家：");
                file.Close();
                file.Dispose();
            }
            if (Computerfirst)//表明如果电脑先手，那么电脑就会根据之前的走法选择最有利于电脑本身的走法             
            {
                if (difficulty)
                    toNextStep();
                else
                    toNextStep_simple();
                displayChess();
            }
        }

        private void 开发团队ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 frm = new Form4();
            frm.StartPosition = FormStartPosition.CenterScreen;         //窗口初始化在屏幕正中间
            frm.Show();         //show()函数表明制定窗口显示状态，在这里表明Form2在窗口中显示
        }

        private void 玩家登录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            log = true;   //用户已登录
            Form3 frm = new Form3();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();

            initializeGame();           //初始化游戏
            Computerfirst = false;      //初始化玩家先手
            flag = 0;     //默认是没选难度
            difficulty = false;         //初始化难度为“新手上路”
            begin = false;
            count = 0;    //没点“开始游戏”
            label3.Text = "请点击“开始游戏”";
        }

        private void 查询成绩ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string strFileName = "data.txt";
            if (File.Exists(strFileName))//判断文件是否存在
            {
                string str = File.ReadAllText("data.txt");
                MessageBox.Show(str, " 查询成绩");  
            }
            else
                MessageBox.Show("用户登录后才能查询分数！", " ERROR"); //显示一个消息框，该消息框包含消息和标题栏标题，并且返回结果。
        }

        private void 现代元素ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Image.FromFile(@"现代元素背景.jpg");
        }

        private void 古典元素ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Image.FromFile(@"古典元素背景.jpg");
        }

        private void 抽象元素ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Image.FromFile(@"抽象元素背景.jpg");
        }
    }
}