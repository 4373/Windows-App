namespace BaseMain.UserUI
{
    partial class AgreeOrNot
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
            this.lblGiveUp = new System.Windows.Forms.Label();
            this.lblAgree = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblGiveUp
            // 
            this.lblGiveUp.BackColor = System.Drawing.Color.LightSlateGray;
            this.lblGiveUp.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblGiveUp.Font = new System.Drawing.Font("幼圆", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblGiveUp.ForeColor = System.Drawing.Color.White;
            this.lblGiveUp.Location = new System.Drawing.Point(0, 0);
            this.lblGiveUp.Name = "lblGiveUp";
            this.lblGiveUp.Size = new System.Drawing.Size(164, 111);
            this.lblGiveUp.TabIndex = 1;
            this.lblGiveUp.Text = "放弃";
            this.lblGiveUp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblGiveUp.Click += new System.EventHandler(this.lblGiveUp_Click);
            this.lblGiveUp.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblGiveUp_MouseDown);
            this.lblGiveUp.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lblGiveUp_MouseUp);
            // 
            // lblAgree
            // 
            this.lblAgree.BackColor = System.Drawing.Color.LightSeaGreen;
            this.lblAgree.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblAgree.Font = new System.Drawing.Font("幼圆", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblAgree.ForeColor = System.Drawing.Color.White;
            this.lblAgree.Location = new System.Drawing.Point(170, 0);
            this.lblAgree.Name = "lblAgree";
            this.lblAgree.Size = new System.Drawing.Size(229, 111);
            this.lblAgree.TabIndex = 2;
            this.lblAgree.Text = "同意";
            this.lblAgree.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAgree.Click += new System.EventHandler(this.lblAgree_Click);
            this.lblAgree.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblAgree_MouseDown);
            this.lblAgree.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lblAgree_MouseUp);
            // 
            // AgreeOrNot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblAgree);
            this.Controls.Add(this.lblGiveUp);
            this.Name = "AgreeOrNot";
            this.Size = new System.Drawing.Size(399, 111);
            this.Resize += new System.EventHandler(this.AgreeOrNotButton_Resize);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblGiveUp;
        private System.Windows.Forms.Label lblAgree;

    }
}
