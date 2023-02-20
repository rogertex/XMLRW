using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace XMLRW
{
   
    public partial class FrmCurves : Form
    {
        private List<double> curve1 = new List<double>();

        private List<double> curve2 = new List<double>();

        private List<double> curve3 = new List<double>();

        private List<double> dateTime = new List<double>();

        private Random random = new Random();
       
        

        public FrmCurves()
        {
            InitializeComponent();
            formsPlot1.Plot.XLabel("时间");
            formsPlot1.Plot.YLabel("数据");
            formsPlot1.Plot.Title("温度");
            formsPlot1.Plot.XAxis.DateTimeFormat(true);

            System.Timers.Timer timerDT = new System.Timers.Timer(1000); //时间显示多线程时钟
            timerDT.Elapsed += UpdateDateTime;
            timerDT.Enabled = true;



        }

        private void UpdateDateTime(object sender, ElapsedEventArgs e)
        {
            this.BeginInvoke(new Action(() =>
            {
                lblDateTime.Text = DateTime.Now.ToString();




            }));


        }



        private void button1_Click(object sender, EventArgs e)
        {
           Task task1= Task.Run(() =>
            {
                while (true)
                {
                    dateTime.Add(DateTime.Now.ToOADate());
                    curve1.Add(random.NextDouble() * 10);
                    curve2.Add(random.NextDouble() * 20);
                    curve3.Add(random.NextDouble() * 30);
                    formsPlot1.Plot.AxisAuto();
                    formsPlot1.Plot.AddSignalXY(dateTime.ToArray(), curve1.ToArray(), System.Drawing.Color.Yellow, "pressure1");
                    formsPlot1.Plot.AddSignalXY(dateTime.ToArray(), curve2.ToArray(), System.Drawing.Color.Red, "pressure2");
                    formsPlot1.Plot.AddSignalXY(dateTime.ToArray(), curve3.ToArray(), System.Drawing.Color.DodgerBlue, "pressure3");
                    this.Invoke(new Action(() =>
                    {
                        formsPlot1.Refresh();

                    }));
                    Thread.Sleep(1000);
                   

                }


            }

                );
        }

        private void btnUserManger_Click(object sender, EventArgs e)
        {
            FrmUserManage frmUserManage= new FrmUserManage();
            frmUserManage.Show();
        }

        private void Curves_Load(object sender, EventArgs e)
        {
            btnLogin.Text = CurrentInfo.btnLogin; //登录按钮可变显示Text
            this.Hide();//把主界面隐藏
            LoginForm loginForm = new LoginForm();
            loginForm.login += Login;
            loginForm.ShowDialog();
           
      
        }

        public void Login(User user)
        {
            this.Visible=true; //把隐藏的主界面显示

            lblUserName.Text = user.Username;
            CurrentInfo.authority = user.Level;
            CurrentInfo.loginOut = false;
            CurrentInfo.btnLogin = "退出登录";

            if (CurrentInfo.loginOut)
            {
                btnUserManger.Enabled = false;
            }
            else
            {
                btnUserManger.Enabled = true;
            }
            btnLogin.Text = CurrentInfo.btnLogin;

            UserTimeOut(10);


        }

        [DllImport("user32.dll")]
        public static extern bool GetCursorPos(out Point pt);
        private void UserTimeOut(int secTime)
        {
            
          Task task2=Task.Run(() =>
            {
                for (int i = 0; i < secTime; i++)
                {
                    GetCursorPos(out Point sourcePoint);
                    Thread.Sleep(1000);
                    GetCursorPos(out Point currentPoint);
                    if (sourcePoint.X != currentPoint.X | sourcePoint.Y != currentPoint.Y)
                    {
                        i = 0;
                    }
                    if (CurrentInfo.loginOut) break;
                  
                }
                LoginOut();
            });
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (CurrentInfo.authority==Authority.empty)
            {
                LoginForm loginForm = new LoginForm();
                loginForm.login += Login;

                //Control[] btnExitApp = loginForm.Controls.Find("btnExitApp", true);
                //if (btnExitApp.Length > 0)
                //{
                //    btnExitApp[0].Hide();

                //}
                
                  


                loginForm.Show();

            }
            else
            {
                LoginOut();
               
            }

           
        }

        private void LoginOut()
        {
           CurrentInfo.authority=Authority.empty;
            lblUserName.Invoke(new Action(() =>
            {
                lblUserName.Text = "No User";

            }));
            CurrentInfo.loginOut=true;
            CurrentInfo.btnLogin = "用户登录";
            if (CurrentInfo.loginOut)
            {
                btnUserManger.Enabled = false;
            }
            else
            {
                btnUserManger.Enabled = true;
            }
            btnLogin.Text = CurrentInfo.btnLogin;
        }

        private void btnAppExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}