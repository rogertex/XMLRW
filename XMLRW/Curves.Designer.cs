
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
            this.formsPlot1 = new ScottPlot.FormsPlot();
            this.btnCurve = new System.Windows.Forms.Button();
            this.btnUserManger = new System.Windows.Forms.Button();
            this.lblUserName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblDateTime = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // formsPlot1
            // 
            this.formsPlot1.Location = new System.Drawing.Point(18, 237);
            this.formsPlot1.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.formsPlot1.Name = "formsPlot1";
            this.formsPlot1.Size = new System.Drawing.Size(1276, 484);
            this.formsPlot1.TabIndex = 0;
            // 
            // btnCurve
            // 
            this.btnCurve.Location = new System.Drawing.Point(35, 27);
            this.btnCurve.Name = "btnCurve";
            this.btnCurve.Size = new System.Drawing.Size(165, 49);
            this.btnCurve.TabIndex = 1;
            this.btnCurve.Text = "数据采集";
            this.btnCurve.UseVisualStyleBackColor = true;
            this.btnCurve.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnUserManger
            // 
            this.btnUserManger.Location = new System.Drawing.Point(35, 103);
            this.btnUserManger.Name = "btnUserManger";
            this.btnUserManger.Size = new System.Drawing.Size(165, 49);
            this.btnUserManger.TabIndex = 1;
            this.btnUserManger.Text = "用户管理";
            this.btnUserManger.UseVisualStyleBackColor = true;
            this.btnUserManger.Click += new System.EventHandler(this.btnUserManger_Click);
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("宋体", 15F);
            this.lblUserName.Location = new System.Drawing.Point(1706, 32);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(90, 25);
            this.lblUserName.TabIndex = 2;
            this.lblUserName.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 15F);
            this.label1.Location = new System.Drawing.Point(1613, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "用户：";
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.Color.SeaShell;
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(1902, 83);
            this.splitter1.TabIndex = 4;
            this.splitter1.TabStop = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(0, 59);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnCurve);
            this.splitContainer1.Panel1.Controls.Add(this.btnLogin);
            this.splitContainer1.Panel1.Controls.Add(this.btnUserManger);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.formsPlot1);
            this.splitContainer1.Size = new System.Drawing.Size(1578, 800);
            this.splitContainer1.SplitterDistance = 255;
            this.splitContainer1.TabIndex = 5;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(35, 706);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(165, 49);
            this.btnLogin.TabIndex = 1;
            this.btnLogin.Text = "用户登录";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblDateTime
            // 
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.Font = new System.Drawing.Font("宋体", 11F);
            this.lblDateTime.Location = new System.Drawing.Point(1615, 9);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(69, 19);
            this.lblDateTime.TabIndex = 6;
            this.lblDateTime.Text = "label2";
            // 
            // FrmCurves
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.lblDateTime);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.splitter1);
            this.Name = "FrmCurves";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCurves";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Curves_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ScottPlot.FormsPlot formsPlot1;
        private System.Windows.Forms.Button btnCurve;
        private System.Windows.Forms.Button btnUserManger;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.Button btnLogin;
    }
}