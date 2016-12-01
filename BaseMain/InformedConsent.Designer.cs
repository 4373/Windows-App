namespace BaseMain
{
    partial class InformedConsent
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InformedConsent));
            this.label3 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.agreeOrNot1 = new BaseMain.UserUI.AgreeOrNot();
            this.agreeOrNotButton1 = new BaseMain.UserUI.AgreeOrNot();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("幼圆", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(523, 45);
            this.label3.TabIndex = 4;
            this.label3.Text = "知情同意书";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.White;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.richTextBox1.Enabled = false;
            this.richTextBox1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.richTextBox1.Location = new System.Drawing.Point(27, 48);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Horizontal;
            this.richTextBox1.Size = new System.Drawing.Size(475, 233);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // agreeOrNot1
            // 
            this.agreeOrNot1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.agreeOrNot1.Location = new System.Drawing.Point(0, 296);
            this.agreeOrNot1.Name = "agreeOrNot1";
            this.agreeOrNot1.Size = new System.Drawing.Size(523, 82);
            this.agreeOrNot1.TabIndex = 8;
            this.agreeOrNot1.AgreeEvent += new System.Action(this.agreeOrNot1_AgreeEvent);
            // 
            // agreeOrNotButton1
            // 
            this.agreeOrNotButton1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.agreeOrNotButton1.Location = new System.Drawing.Point(0, 296);
            this.agreeOrNotButton1.Name = "agreeOrNotButton1";
            this.agreeOrNotButton1.Size = new System.Drawing.Size(523, 82);
            this.agreeOrNotButton1.TabIndex = 6;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // InformedConsent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(523, 378);
            this.Controls.Add(this.agreeOrNot1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InformedConsent";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private UserUI.AgreeOrNot agreeOrNotButton1;
        private UserUI.AgreeOrNot agreeOrNot1;
        private System.Windows.Forms.Timer timer1;
    }
}

