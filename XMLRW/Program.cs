using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;

namespace XMLRW
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        
        
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //LoginForm loginForm = new LoginForm(); 
            //loginForm.ShowDialog();
            //if (loginForm.DialogResult==DialogResult.OK) //登录窗口登录成功后打开主窗口
            //{
            //    Application.Run(new Curves()); //打开主窗口

            //}

            {
                Application.Run(new Curves()); //打开主窗口

            }




        }
    }
}
