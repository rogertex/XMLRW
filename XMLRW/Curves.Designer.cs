
namespace XMLRW
{
    partial class Curves
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
            this.SuspendLayout();
            // 
            // formsPlot1
            // 
            this.formsPlot1.Location = new System.Drawing.Point(38, 28);
            this.formsPlot1.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.formsPlot1.Name = "formsPlot1";
            this.formsPlot1.Size = new System.Drawing.Size(992, 516);
            this.formsPlot1.TabIndex = 0;
            // 
            // btnCurve
            // 
            this.btnCurve.Location = new System.Drawing.Point(1038, 58);
            this.btnCurve.Name = "btnCurve";
            this.btnCurve.Size = new System.Drawing.Size(165, 52);
            this.btnCurve.TabIndex = 1;
            this.btnCurve.Text = "数据采集";
            this.btnCurve.UseVisualStyleBackColor = true;
            this.btnCurve.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnUserManger
            // 
            this.btnUserManger.Location = new System.Drawing.Point(1038, 127);
            this.btnUserManger.Name = "btnUserManger";
            this.btnUserManger.Size = new System.Drawing.Size(165, 52);
            this.btnUserManger.TabIndex = 1;
            this.btnUserManger.Text = "用户管理";
            this.btnUserManger.UseVisualStyleBackColor = true;
            this.btnUserManger.Click += new System.EventHandler(this.btnUserManger_Click);
            // 
            // Curves
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1258, 640);
            this.Controls.Add(this.btnUserManger);
            this.Controls.Add(this.btnCurve);
            this.Controls.Add(this.formsPlot1);
            this.Name = "Curves";
            this.Text = "Curves";
            this.ResumeLayout(false);

        }

        #endregion

        private ScottPlot.FormsPlot formsPlot1;
        private System.Windows.Forms.Button btnCurve;
        private System.Windows.Forms.Button btnUserManger;
    }
}