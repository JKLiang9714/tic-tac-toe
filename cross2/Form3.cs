using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace cross2
{
    public partial class Form3 : Form
    {
        string sex;   //性别

        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == string.Empty)
            {
                MessageBox.Show("警告：玩家姓名不能为空", " ERROR");
            }
            else
            {
                string[] lines = {textBox1.Text};
                File.WriteAllLines("data.txt", lines);
                if (radioButton1.Checked) //先判断radioButton1是否处于选择状态
                    sex = radioButton1.Text;
                else if (radioButton2.Checked) //再判断radioButton2是否处于选择状态
                    sex = radioButton2.Text;
                using (StreamWriter file = new StreamWriter("data.txt", true))  //将文本追加到现有文件data.txt
                {
                    file.WriteLine(sex);
                    file.Close();
                    file.Dispose();
                }
                MessageBox.Show("用户登录成功！", " 提示");
                this.Close();
            }
            
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.button1_Click(button1, null);      //在textBox按回车键就执行button1的单击事件
            }
        }

    }
}