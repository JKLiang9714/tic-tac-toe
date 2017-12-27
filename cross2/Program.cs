using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace cross2
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();               //应用程序启用可视样式             
            Application.SetCompatibleTextRenderingDefault(false);       //在应用程序范围内设置控件显示文本的默认方式 
            Application.Run(new Form1());               //用户登录之后出现游戏界面  
        }
    }
}
