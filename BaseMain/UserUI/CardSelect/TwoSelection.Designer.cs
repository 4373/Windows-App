namespace BaseMain.UserUI.CardSelect
{
    partial class TwoSelection
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblContent1 = new System.Windows.Forms.Label();
            this.lblTitle1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblContent2 = new System.Windows.Forms.Label();
            this.lblTitle2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblContent1);
            this.panel1.Controls.Add(this.lblTitle1);
            this.panel1.Location = new System.Drawing.Point(33, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(235, 139);
            this.panel1.TabIndex = 0;
            this.panel1.Click += new System.EventHandler(this.panel1_Click);
            // 
            // lblContent1
            // 
            this.lblContent1.BackColor = System.Drawing.Color.DarkOrange;
            this.lblContent1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblContent1.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblContent1.Location = new System.Drawing.Point(0, 82);
            this.lblContent1.Name = "lblContent1";
            this.lblContent1.Size = new System.Drawing.Size(233, 55);
            this.lblContent1.TabIndex = 0;
            this.lblContent1.Text = "label2";
            this.lblContent1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblContent1.Click += new System.EventHandler(this.panel1_Click);
            // 
            // lblTitle1
            // 
            this.lblTitle1.BackColor = System.Drawing.Color.YellowGreen;
            this.lblTitle1.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle1.Location = new System.Drawing.Point(0, 0);
            this.lblTitle1.Name = "lblTitle1";
            this.lblTitle1.Size = new System.Drawing.Size(233, 84);
            this.lblTitle1.TabIndex = 0;
            this.lblTitle1.Text = "label1";
            this.lblTitle1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitle1.Click += new System.EventHandler(this.panel1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lblContent2);
            this.panel2.Controls.Add(this.lblTitle2);
            this.panel2.Location = new System.Drawing.Point(274, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(239, 139);
            this.panel2.TabIndex = 1;
            this.panel2.Click += new System.EventHandler(this.panel2_Click);
            // 
            // lblContent2
            // 
            this.lblContent2.BackColor = System.Drawing.Color.DarkOrange;
            this.lblContent2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblContent2.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblContent2.Location = new System.Drawing.Point(0, 82);
            this.lblContent2.Name = "lblContent2";
            this.lblContent2.Size = new System.Drawing.Size(237, 55);
            this.lblContent2.TabIndex = 1;
            this.lblContent2.Text = "label2";
            this.lblContent2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblContent2.Click += new System.EventHandler(this.panel2_Click);
            // 
            // lblTitle2
            // 
            this.lblTitle2.BackColor = System.Drawing.Color.YellowGreen;
            this.lblTitle2.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle2.Location = new System.Drawing.Point(0, 0);
            this.lblTitle2.Name = "lblTitle2";
            this.lblTitle2.Size = new System.Drawing.Size(237, 82);
            this.lblTitle2.TabIndex = 1;
            this.lblTitle2.Text = "label1";
            this.lblTitle2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitle2.Click += new System.EventHandler(this.panel2_Click);
            // 
            // TwoSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "TwoSelection";
            this.Size = new System.Drawing.Size(550, 196);
            this.Resize += new System.EventHandler(this.TwoSelection_Resize);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitle1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblContent1;
        private System.Windows.Forms.Label lblContent2;
        private System.Windows.Forms.Label lblTitle2;
    }
}
