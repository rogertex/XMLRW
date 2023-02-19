
namespace XMLRW
{
    partial class FrmCurves
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCurve = new System.Windows.Forms.Button();
            this.btnUserManger = new System.Windows.Forms.Button();
            this.lblUserName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.formsPlot1 = new ScottPlot.FormsPlot();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.btnAppExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCurve
            // 
            this.btnCurve.Location = new System.Drawing.Point(30, 20);
            this.btnCurve.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCurve.Name = "btnCurve";
            this.btnCurve.Size = new System.Drawing.Size(160, 43);
            this.btnCurve.TabIndex = 1;
            this.btnCurve.Text = "数据采集";
            this.btnCurve.UseVisualStyleBackColor = true;
            this.btnCurve.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnUserManger
            // 
            this.btnUserManger.Location = new System.Drawing.Point(30, 81);
            this.btnUserManger.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnUserManger.Name = "btnUserManger";
            this.btnUserManger.Size = new System.Drawing.Size(160, 43);
            this.btnUserManger.TabIndex = 1;
            this.btnUserManger.Text = "用户管理";
            this.btnUserManger.UseVisualStyleBackColor = true;
            this.btnUserManger.Click += new System.EventHandler(this.btnUserManger_Click);
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("宋体", 15F);
            this.lblUserName.Location = new System.Drawing.Point(1357, 32);
            this.lblUserName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(69, 20);
            this.lblUserName.TabIndex = 2;
            this.lblUserName.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 15F);
            this.label1.Location = new System.Drawing.Point(1287, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "用户：";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(30, 136);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(160, 43);
            this.btnLogin.TabIndex = 1;
            this.btnLogin.Text = "用户登录";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblDateTime
            // 
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.Font = new System.Drawing.Font("宋体", 11F);
            this.lblDateTime.Location = new System.Drawing.Point(1279, 7);
            this.lblDateTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(55, 15);
            this.lblDateTime.TabIndex = 6;
            this.lblDateTime.Text = "label2";
            // 
            // formsPlot1
            // 
            this.formsPlot1.Location = new System.Drawing.Point(279, 0);
            this.formsPlot1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.formsPlot1.Name = "formsPlot1";
            this.formsPlot1.Size = new System.Drawing.Size(983, 722);
            this.formsPlot1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::XMLRW.Properties.Resources.lockRotor;
            this.pictureBox1.Location = new System.Drawing.Point(17, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(72, 65);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCurve);
            this.panel1.Controls.Add(this.btnUserManger);
            this.panel1.Controls.Add(this.btnAppExit);
            this.panel1.Controls.Add(this.btnLogin);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 80);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(233, 730);
            this.panel1.TabIndex = 8;
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.formsPlot1);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(0, 80);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(1396, 730);
            this.metroPanel1.TabIndex = 9;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // btnAppExit
            // 
            this.btnAppExit.Location = new System.Drawing.Point(30, 201);
            this.btnAppExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnAppExit.Name = "btnAppExit";
            this.btnAppExit.Size = new System.Drawing.Size(160, 43);
            this.btnAppExit.TabIndex = 1;
            this.btnAppExit.Text = "退出程序";
            this.btnAppExit.UseVisualStyleBackColor = true;
            this.btnAppExit.Click += new System.EventHandler(this.btnAppExit_Click);
            // 
            // FrmCurves
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1426, 826);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblDateTime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.metroPanel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmCurves";
            this.Padding = new System.Windows.Forms.Padding(0, 80, 30, 16);
            this.Style = MetroFramework.MetroColorStyle.Silver;
            this.Text = "           DAQ for LockRotor";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Curves_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.metroPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCurve;
        private System.Windows.Forms.Button btnUserManger;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.Button btnLogin;
        private ScottPlot.FormsPlot formsPlot1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private System.Windows.Forms.Button btnAppExit;
    }
}