namespace BaseMain.UserUI.ControlMove
{
    partial class PrintDataOrNot
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
            this.lblPrint = new System.Windows.Forms.Label();
            this.lblGiveUp = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPrint
            // 
            this.lblPrint.BackColor = System.Drawing.Color.LightSeaGreen;
            this.lblPrint.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblPrint.Font = new System.Drawing.Font("幼圆", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblPrint.ForeColor = System.Drawing.Color.White;
            this.lblPrint.Location = new System.Drawing.Point(168, 0);
            this.lblPrint.Name = "lblPrint";
            this.lblPrint.Size = new System.Drawing.Size(229, 131);
            this.lblPrint.TabIndex = 4;
            this.lblPrint.Text = "打印报告";
            this.lblPrint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPrint.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblAgree_MouseDown_1);
            this.lblPrint.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lblAgree_MouseUp_1);
            // 
            // lblGiveUp
            // 
            this.lblGiveUp.BackColor = System.Drawing.Color.LightSlateGray;
            this.lblGiveUp.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblGiveUp.Font = new System.Drawing.Font("幼圆", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblGiveUp.ForeColor = System.Drawing.Color.White;
            this.lblGiveUp.Location = new System.Drawing.Point(0, 0);
            this.lblGiveUp.Name = "lblGiveUp";
            this.lblGiveUp.Size = new System.Drawing.Size(164, 131);
            this.lblGiveUp.TabIndex = 3;
            this.lblGiveUp.Text = "放弃";
            this.lblGiveUp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblGiveUp.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblGiveUp_MouseDown_1);
            this.lblGiveUp.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lblGiveUp_MouseUp_1);
            // 
            // PrintDataOrNot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblPrint);
            this.Controls.Add(this.lblGiveUp);
            this.Name = "PrintDataOrNot";
            this.Size = new System.Drawing.Size(397, 131);
            this.Resize += new System.EventHandler(this.PrintDataOrNot_Resize);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblPrint;
        private System.Windows.Forms.Label lblGiveUp;
    }
}
