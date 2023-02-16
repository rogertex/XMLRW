using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XMLRW
{
    public partial class Curves : Form
    {
        private List<double> curve1 = new List<double>();

        private List<double> curve2 = new List<double>();

        private List<double> curve3 = new List<double>();

        private List<double> dateTime = new List<double>();

        private Random random = new Random();

        public Curves()
        {
            InitializeComponent();
            formsPlot1.Plot.XLabel("时间");
            formsPlot1.Plot.YLabel("数据");
            formsPlot1.Plot.Title("温度");
            formsPlot1.Plot.XAxis.DateTimeFormat(true);

        }
        private void button1_Click(object sender, EventArgs e)
        {
            Task.Run(() =>
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
                        formsPlot1.Render();

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
    }
}