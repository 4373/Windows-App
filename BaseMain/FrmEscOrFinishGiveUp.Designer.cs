namespace BaseMain
{
    partial class FrmEscOrFinishGiveUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEscOrFinishGiveUp));
            this.panel1 = new System.Windows.Forms.Panel();
            this.escFromFillIn1 = new BaseMain.UserUI.AskWhenFinishOrEsc();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.escFromFillIn1);
            this.panel1.Location = new System.Drawing.Point(96, 67);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(651, 459);
            this.panel1.TabIndex = 0;
            // 
            // escFromFillIn1
            // 
            this.escFromFillIn1.Ask = null;
            this.escFromFillIn1.BackColor = System.Drawing.Color.White;
            this.escFromFillIn1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.escFromFillIn1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.escFromFillIn1.Location = new System.Drawing.Point(0, 0);
            this.escFromFillIn1.Name = "escFromFillIn1";
            this.escFromFillIn1.Size = new System.Drawing.Size(651, 459);
            this.escFromFillIn1.TabIndex = 0;
            this.escFromFillIn1.Warning = null;
            // 
            // FrmEsc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(838, 556);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmEsc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmEsc";
            this.TransparencyKey = System.Drawing.Color.Ivory;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Resize += new System.EventHandler(this.FrmEsc_Resize);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private UserUI.AskWhenFinishOrEsc escFromFillIn1;






    }
}