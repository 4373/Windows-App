namespace BaseMain.UserUI
{
    partial class AskWhenFinishOrEsc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AskWhenFinishOrEsc));
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblContent = new System.Windows.Forms.Label();
            this.lblNot = new System.Windows.Forms.Label();
            this.lblOk = new System.Windows.Forms.Label();
            this.lblPic = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Location = new System.Drawing.Point(0, 104);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(446, 61);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "确认放弃本次筛查报告填写吗";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblContent
            // 
            this.lblContent.Location = new System.Drawing.Point(3, 167);
            this.lblContent.Name = "lblContent";
            this.lblContent.Size = new System.Drawing.Size(446, 36);
            this.lblContent.TabIndex = 2;
            this.lblContent.Text = "*本次已填写的内容将不会被保存";
            this.lblContent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNot
            // 
            this.lblNot.BackColor = System.Drawing.Color.LightSlateGray;
            this.lblNot.Location = new System.Drawing.Point(-2, 273);
            this.lblNot.Name = "lblNot";
            this.lblNot.Size = new System.Drawing.Size(222, 49);
            this.lblNot.TabIndex = 3;
            this.lblNot.Text = "取消";
            this.lblNot.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNot.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblNot_MouseDown);
            this.lblNot.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lblNot_MouseUp);
            // 
            // lblOk
            // 
            this.lblOk.BackColor = System.Drawing.Color.DarkTurquoise;
            this.lblOk.Location = new System.Drawing.Point(226, 273);
            this.lblOk.Name = "lblOk";
            this.lblOk.Size = new System.Drawing.Size(220, 49);
            this.lblOk.TabIndex = 4;
            this.lblOk.Text = "确定";
            this.lblOk.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblOk.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblOk_MouseDown);
            this.lblOk.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lblOk_MouseUp);
            // 
            // lblPic
            // 
            this.lblPic.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblPic.Image = ((System.Drawing.Image)(resources.GetObject("lblPic.Image")));
            this.lblPic.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblPic.Location = new System.Drawing.Point(0, 0);
            this.lblPic.Name = "lblPic";
            this.lblPic.Size = new System.Drawing.Size(445, 104);
            this.lblPic.TabIndex = 0;
            // 
            // EscFromFillIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblOk);
            this.Controls.Add(this.lblNot);
            this.Controls.Add(this.lblContent);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblPic);
            this.Name = "EscFromFillIn";
            this.Size = new System.Drawing.Size(445, 322);
            this.Load += new System.EventHandler(this.EscFromFillIn_Load);
            this.Resize += new System.EventHandler(this.EscFromFillIn_Resize);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblPic;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblContent;
        private System.Windows.Forms.Label lblNot;
        private System.Windows.Forms.Label lblOk;
    }
}
