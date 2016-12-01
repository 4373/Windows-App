namespace BaseMain.UserUI.ControlMove
{
    partial class OnlyNext
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
            this.lblNext = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNext
            // 
            this.lblNext.BackColor = System.Drawing.Color.DarkTurquoise;
            this.lblNext.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNext.Font = new System.Drawing.Font("幼圆", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblNext.ForeColor = System.Drawing.Color.White;
            this.lblNext.Location = new System.Drawing.Point(0, 0);
            this.lblNext.Name = "lblNext";
            this.lblNext.Size = new System.Drawing.Size(447, 109);
            this.lblNext.TabIndex = 4;
            this.lblNext.Text = "下一步";
            this.lblNext.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNext.Click += new System.EventHandler(this.lblNext_Click);
            this.lblNext.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblNext_MouseDown);
            this.lblNext.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lblNext_MouseUp);
            // 
            // OnlyNext
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblNext);
            this.Name = "OnlyNext";
            this.Size = new System.Drawing.Size(447, 109);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblNext;
    }
}
