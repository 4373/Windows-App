namespace BaseMain
{
    partial class FrmMain
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
        /// Required method for Designer support - do Not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timerNext = new System.Windows.Forms.Timer(this.components);
            this.timerPre = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.timerAskToReport = new System.Windows.Forms.Timer(this.components);
            this.timerGiveUp = new System.Windows.Forms.Timer(this.components);
            this.timerPrint = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // timerNext
            // 
            this.timerNext.Interval = 10;
            this.timerNext.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timerPre
            // 
            this.timerPre.Interval = 1;
            this.timerPre.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(134, 50);
            this.panel2.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel1.Location = new System.Drawing.Point(24, 124);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(512, 336);
            this.panel1.TabIndex = 0;
            this.panel1.Resize += new System.EventHandler(this.panel1_Resize);
            // 
            // timerAskToReport
            // 
            this.timerAskToReport.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // timerGiveUp
            // 
            this.timerGiveUp.Tick += new System.EventHandler(this.timerGiveUp_Tick);
            // 
            // timerPrint
            // 
            this.timerPrint.Tick += new System.EventHandler(this.timerFinish_Tick);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 336);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.Resize += new System.EventHandler(this.FrmMain_Resize);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timerNext;
        private System.Windows.Forms.Timer timerPre;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer timerAskToReport;
        private System.Windows.Forms.Timer timerGiveUp;
        private System.Windows.Forms.Timer timerPrint;
    }
}