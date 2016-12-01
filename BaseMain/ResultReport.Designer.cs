namespace BaseMain
{
    partial class ResultReport
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
            this.components = new System.ComponentModel.Container();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.timerGiveUpPrint = new System.Windows.Forms.Timer(this.components);
            this.familyData1 = new BaseMain.UserUI.Report.FamilyData();
            this.baseInfo1 = new BaseMain.UserUI.Report.BaseInfo();
            this.healthStation1 = new BaseMain.UserUI.Report.HealthStation();
            this.lifeStyle1 = new BaseMain.UserUI.Report.LifeStyle();
            this.printDataOrNot1 = new BaseMain.UserUI.ControlMove.PrintDataOrNot();
            this.panel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("微软雅黑", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(912, 72);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "结果报告";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitle.MouseEnter += new System.EventHandler(this.lblTitle_MouseEnter);
            this.lblTitle.MouseLeave += new System.EventHandler(this.lblTitle_MouseLeave);
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.White;
            this.panel.Controls.Add(this.panel1);
            this.panel.Location = new System.Drawing.Point(0, 75);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(912, 325);
            this.panel.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.familyData1);
            this.panel1.Controls.Add(this.baseInfo1);
            this.panel1.Controls.Add(this.healthStation1);
            this.panel1.Controls.Add(this.lifeStyle1);
            this.panel1.Location = new System.Drawing.Point(3, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(909, 312);
            this.panel1.TabIndex = 0;
            // 
            // timerGiveUpPrint
            // 
            this.timerGiveUpPrint.Tick += new System.EventHandler(this.timerGiveUpPrint_Tick);
            // 
            // familyData1
            // 
            this.familyData1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.familyData1.Location = new System.Drawing.Point(477, 75);
            this.familyData1.Name = "familyData1";
            this.familyData1.Size = new System.Drawing.Size(358, 105);
            this.familyData1.TabIndex = 3;
            // 
            // baseInfo1
            // 
            this.baseInfo1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.baseInfo1.BaseAge = null;
            this.baseInfo1.BaseHeight = null;
            this.baseInfo1.BaseId = null;
            this.baseInfo1.BaseName = null;
            this.baseInfo1.BaseSex = null;
            this.baseInfo1.BaseTime = null;
            this.baseInfo1.BaseWaist = null;
            this.baseInfo1.BaseWeight = null;
            this.baseInfo1.Location = new System.Drawing.Point(9, 211);
            this.baseInfo1.Name = "baseInfo1";
            this.baseInfo1.Size = new System.Drawing.Size(322, 98);
            this.baseInfo1.TabIndex = 0;
            // 
            // healthStation1
            // 
            this.healthStation1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.healthStation1.BloodPressure = null;
            this.healthStation1.BloodSugar = null;
            this.healthStation1.BSugarHeredity = false;
            this.healthStation1.FamilyStroke = false;
            this.healthStation1.HighCholesterol = false;
            this.healthStation1.Location = new System.Drawing.Point(3, 93);
            this.healthStation1.Name = "healthStation1";
            this.healthStation1.Size = new System.Drawing.Size(387, 96);
            this.healthStation1.TabIndex = 2;
            this.healthStation1.UseHypotensor = false;
            // 
            // lifeStyle1
            // 
            this.lifeStyle1.AutoScroll = true;
            this.lifeStyle1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lifeStyle1.Location = new System.Drawing.Point(40, 16);
            this.lifeStyle1.Name = "lifeStyle1";
            this.lifeStyle1.Size = new System.Drawing.Size(325, 71);
            this.lifeStyle1.Smoking = false;
            this.lifeStyle1.Sport = false;
            this.lifeStyle1.TabIndex = 1;
            // 
            // printDataOrNot1
            // 
            this.printDataOrNot1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.printDataOrNot1.Location = new System.Drawing.Point(0, 398);
            this.printDataOrNot1.Name = "printDataOrNot1";
            this.printDataOrNot1.Size = new System.Drawing.Size(912, 75);
            this.printDataOrNot1.TabIndex = 3;
            // 
            // ResultReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(912, 473);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.printDataOrNot1);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ResultReport";
            this.Text = "ResultReport";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Resize += new System.EventHandler(this.ResultReport_Resize);
            this.panel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private UserUI.ControlMove.PrintDataOrNot printDataOrNot1;
        private System.Windows.Forms.Panel panel;
        private UserUI.Report.FamilyData familyData1;
        private UserUI.Report.HealthStation healthStation1;
        private UserUI.Report.LifeStyle lifeStyle1;
        private UserUI.Report.BaseInfo baseInfo1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer timerGiveUpPrint;







    }
}