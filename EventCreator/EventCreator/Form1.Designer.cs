namespace EventCreator
{
    partial class frmMain
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
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabGeneralInfo = new System.Windows.Forms.TabPage();
            this.Advice = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.lblHunter = new System.Windows.Forms.Label();
            this.txtHunter = new System.Windows.Forms.TextBox();
            this.chkHunter = new System.Windows.Forms.CheckBox();
            this.tabMain.SuspendLayout();
            this.Advice.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tabGeneralInfo);
            this.tabMain.Controls.Add(this.Advice);
            this.tabMain.Controls.Add(this.tabPage3);
            this.tabMain.Controls.Add(this.tabPage4);
            this.tabMain.Controls.Add(this.tabPage5);
            this.tabMain.Location = new System.Drawing.Point(0, 0);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(862, 542);
            this.tabMain.TabIndex = 0;
            // 
            // tabGeneralInfo
            // 
            this.tabGeneralInfo.Location = new System.Drawing.Point(4, 22);
            this.tabGeneralInfo.Name = "tabGeneralInfo";
            this.tabGeneralInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabGeneralInfo.Size = new System.Drawing.Size(854, 516);
            this.tabGeneralInfo.TabIndex = 0;
            this.tabGeneralInfo.Text = "General Info";
            this.tabGeneralInfo.UseVisualStyleBackColor = true;
            // 
            // Advice
            // 
            this.Advice.Controls.Add(this.chkHunter);
            this.Advice.Controls.Add(this.txtHunter);
            this.Advice.Controls.Add(this.lblHunter);
            this.Advice.Location = new System.Drawing.Point(4, 22);
            this.Advice.Name = "Advice";
            this.Advice.Padding = new System.Windows.Forms.Padding(3);
            this.Advice.Size = new System.Drawing.Size(854, 516);
            this.Advice.TabIndex = 1;
            this.Advice.Text = "Advice";
            this.Advice.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(854, 516);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(854, 516);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(854, 516);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "tabPage5";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // lblHunter
            // 
            this.lblHunter.AutoSize = true;
            this.lblHunter.Location = new System.Drawing.Point(8, 30);
            this.lblHunter.Name = "lblHunter";
            this.lblHunter.Size = new System.Drawing.Size(39, 13);
            this.lblHunter.TabIndex = 0;
            this.lblHunter.Text = "Hunter";
            // 
            // txtHunter
            // 
            this.txtHunter.Location = new System.Drawing.Point(53, 27);
            this.txtHunter.Name = "txtHunter";
            this.txtHunter.Size = new System.Drawing.Size(504, 20);
            this.txtHunter.TabIndex = 1;
            // 
            // chkHunter
            // 
            this.chkHunter.AutoSize = true;
            this.chkHunter.Location = new System.Drawing.Point(563, 29);
            this.chkHunter.Name = "chkHunter";
            this.chkHunter.Size = new System.Drawing.Size(15, 14);
            this.chkHunter.TabIndex = 2;
            this.chkHunter.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 538);
            this.Controls.Add(this.tabMain);
            this.Name = "frmMain";
            this.Text = "Event Creator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabMain.ResumeLayout(false);
            this.Advice.ResumeLayout(false);
            this.Advice.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabGeneralInfo;
        private System.Windows.Forms.TabPage Advice;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.CheckBox chkHunter;
        private System.Windows.Forms.TextBox txtHunter;
        private System.Windows.Forms.Label lblHunter;

    }
}

