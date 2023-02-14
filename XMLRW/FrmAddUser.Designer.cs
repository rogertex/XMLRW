
namespace XMLRW
{
    partial class FrmAddUser
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
            this.cbxLevel = new System.Windows.Forms.ComboBox();
            this.btnExitApp = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtBoxPWD = new System.Windows.Forms.TextBox();
            this.txtBoxName = new System.Windows.Forms.TextBox();
            this.lblAuthority = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbxLevel
            // 
            this.cbxLevel.FormattingEnabled = true;
            this.cbxLevel.Location = new System.Drawing.Point(186, 144);
            this.cbxLevel.Name = "cbxLevel";
            this.cbxLevel.Size = new System.Drawing.Size(121, 21);
            this.cbxLevel.TabIndex = 13;
            // 
            // btnExitApp
            // 
            this.btnExitApp.Location = new System.Drawing.Point(231, 181);
            this.btnExitApp.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnExitApp.Name = "btnExitApp";
            this.btnExitApp.Size = new System.Drawing.Size(76, 20);
            this.btnExitApp.TabIndex = 11;
            this.btnExitApp.Text = "取消";
            this.btnExitApp.UseVisualStyleBackColor = true;
            this.btnExitApp.Click += new System.EventHandler(this.btnExitApp_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(126, 181);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(56, 20);
            this.btnLogin.TabIndex = 8;
            this.btnLogin.Text = "确定";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // txtBoxPWD
            // 
            this.txtBoxPWD.Location = new System.Drawing.Point(186, 109);
            this.txtBoxPWD.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtBoxPWD.Name = "txtBoxPWD";
            this.txtBoxPWD.Size = new System.Drawing.Size(121, 20);
            this.txtBoxPWD.TabIndex = 7;
            // 
            // txtBoxName
            // 
            this.txtBoxName.Location = new System.Drawing.Point(186, 72);
            this.txtBoxName.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.Size = new System.Drawing.Size(121, 20);
            this.txtBoxName.TabIndex = 6;
            // 
            // lblAuthority
            // 
            this.lblAuthority.AutoSize = true;
            this.lblAuthority.Location = new System.Drawing.Point(123, 147);
            this.lblAuthority.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAuthority.Name = "lblAuthority";
            this.lblAuthority.Size = new System.Drawing.Size(43, 13);
            this.lblAuthority.TabIndex = 9;
            this.lblAuthority.Text = "等级：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(123, 112);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "密码：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(123, 72);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "登录：";
            // 
            // FrmAddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 237);
            this.Controls.Add(this.cbxLevel);
            this.Controls.Add(this.btnExitApp);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtBoxPWD);
            this.Controls.Add(this.txtBoxName);
            this.Controls.Add(this.lblAuthority);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmAddUser";
            this.Text = "FrmAddUser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxLevel;
        private System.Windows.Forms.Button btnExitApp;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtBoxPWD;
        private System.Windows.Forms.TextBox txtBoxName;
        private System.Windows.Forms.Label lblAuthority;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}