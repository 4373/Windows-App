namespace BaseMain.UserUI.Report
{
    partial class LifeStyle
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelSport = new System.Windows.Forms.Panel();
            this.lblShowMessage = new System.Windows.Forms.Label();
            this.cBoxSportNo = new System.Windows.Forms.CheckBox();
            this.cBoxSportYes = new System.Windows.Forms.CheckBox();
            this.panelsmoke = new System.Windows.Forms.Panel();
            this.cBoxSmokeNo = new System.Windows.Forms.CheckBox();
            this.cBoxSmokeYes = new System.Windows.Forms.CheckBox();
            this.lblNSport = new System.Windows.Forms.Label();
            this.lblNSmoking = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panelSport.SuspendLayout();
            this.panelsmoke.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(526, 53);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "生活习惯";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panelSport);
            this.panel1.Controls.Add(this.panelsmoke);
            this.panel1.Controls.Add(this.lblNSport);
            this.panel1.Controls.Add(this.lblNSmoking);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(526, 164);
            this.panel1.TabIndex = 3;
            // 
            // panelSport
            // 
            this.panelSport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSport.Controls.Add(this.lblShowMessage);
            this.panelSport.Controls.Add(this.cBoxSportNo);
            this.panelSport.Controls.Add(this.cBoxSportYes);
            this.panelSport.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelSport.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.panelSport.Location = new System.Drawing.Point(355, 0);
            this.panelSport.Margin = new System.Windows.Forms.Padding(0);
            this.panelSport.Name = "panelSport";
            this.panelSport.Size = new System.Drawing.Size(171, 164);
            this.panelSport.TabIndex = 3;
            // 
            // lblShowMessage
            // 
            this.lblShowMessage.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblShowMessage.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblShowMessage.Location = new System.Drawing.Point(0, 72);
            this.lblShowMessage.Name = "lblShowMessage";
            this.lblShowMessage.Size = new System.Drawing.Size(169, 90);
            this.lblShowMessage.TabIndex = 6;
            this.lblShowMessage.Text = "缺乏运动参考值:\r\n1 运动强度<4-5次/周,持续20-30分钟/次\r\n2 运动强度<4-5次/周,持续20-30分钟/次\r\n";
            this.lblShowMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cBoxSportNo
            // 
            this.cBoxSportNo.AutoCheck = false;
            this.cBoxSportNo.AutoSize = true;
            this.cBoxSportNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cBoxSportNo.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cBoxSportNo.Location = new System.Drawing.Point(92, 19);
            this.cBoxSportNo.Name = "cBoxSportNo";
            this.cBoxSportNo.Size = new System.Drawing.Size(49, 32);
            this.cBoxSportNo.TabIndex = 5;
            this.cBoxSportNo.Text = "否";
            this.cBoxSportNo.UseVisualStyleBackColor = true;
            // 
            // cBoxSportYes
            // 
            this.cBoxSportYes.AutoCheck = false;
            this.cBoxSportYes.AutoSize = true;
            this.cBoxSportYes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cBoxSportYes.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cBoxSportYes.Location = new System.Drawing.Point(25, 19);
            this.cBoxSportYes.Name = "cBoxSportYes";
            this.cBoxSportYes.Size = new System.Drawing.Size(49, 32);
            this.cBoxSportYes.TabIndex = 4;
            this.cBoxSportYes.Text = "是";
            this.cBoxSportYes.UseVisualStyleBackColor = true;
            // 
            // panelsmoke
            // 
            this.panelsmoke.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelsmoke.Controls.Add(this.cBoxSmokeNo);
            this.panelsmoke.Controls.Add(this.cBoxSmokeYes);
            this.panelsmoke.Location = new System.Drawing.Point(93, -4);
            this.panelsmoke.Margin = new System.Windows.Forms.Padding(0);
            this.panelsmoke.Name = "panelsmoke";
            this.panelsmoke.Size = new System.Drawing.Size(154, 168);
            this.panelsmoke.TabIndex = 2;
            // 
            // cBoxSmokeNo
            // 
            this.cBoxSmokeNo.AutoCheck = false;
            this.cBoxSmokeNo.AutoSize = true;
            this.cBoxSmokeNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cBoxSmokeNo.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cBoxSmokeNo.Location = new System.Drawing.Point(104, 78);
            this.cBoxSmokeNo.Name = "cBoxSmokeNo";
            this.cBoxSmokeNo.Size = new System.Drawing.Size(49, 32);
            this.cBoxSmokeNo.TabIndex = 3;
            this.cBoxSmokeNo.Text = "否";
            this.cBoxSmokeNo.UseVisualStyleBackColor = true;
            // 
            // cBoxSmokeYes
            // 
            this.cBoxSmokeYes.AutoCheck = false;
            this.cBoxSmokeYes.AutoSize = true;
            this.cBoxSmokeYes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cBoxSmokeYes.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cBoxSmokeYes.Location = new System.Drawing.Point(37, 78);
            this.cBoxSmokeYes.Name = "cBoxSmokeYes";
            this.cBoxSmokeYes.Size = new System.Drawing.Size(49, 32);
            this.cBoxSmokeYes.TabIndex = 2;
            this.cBoxSmokeYes.Text = "是";
            this.cBoxSmokeYes.UseVisualStyleBackColor = true;
            // 
            // lblNSport
            // 
            this.lblNSport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNSport.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblNSport.Location = new System.Drawing.Point(269, 0);
            this.lblNSport.Margin = new System.Windows.Forms.Padding(0);
            this.lblNSport.Name = "lblNSport";
            this.lblNSport.Size = new System.Drawing.Size(80, 164);
            this.lblNSport.TabIndex = 1;
            this.lblNSport.Text = "是否缺乏运动";
            this.lblNSport.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNSmoking
            // 
            this.lblNSmoking.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNSmoking.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblNSmoking.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblNSmoking.Location = new System.Drawing.Point(0, 0);
            this.lblNSmoking.Name = "lblNSmoking";
            this.lblNSmoking.Size = new System.Drawing.Size(87, 164);
            this.lblNSmoking.TabIndex = 0;
            this.lblNSmoking.Text = "是否吸烟";
            this.lblNSmoking.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LifeStyle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblTitle);
            this.Name = "LifeStyle";
            this.Size = new System.Drawing.Size(526, 217);
            this.Load += new System.EventHandler(this.LifeStyle_Load);
            this.Resize += new System.EventHandler(this.LifeStyle_Resize);
            this.panel1.ResumeLayout(false);
            this.panelSport.ResumeLayout(false);
            this.panelSport.PerformLayout();
            this.panelsmoke.ResumeLayout(false);
            this.panelsmoke.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelSport;
        private System.Windows.Forms.CheckBox cBoxSportNo;
        private System.Windows.Forms.CheckBox cBoxSportYes;
        private System.Windows.Forms.Panel panelsmoke;
        private System.Windows.Forms.CheckBox cBoxSmokeNo;
        private System.Windows.Forms.CheckBox cBoxSmokeYes;
        private System.Windows.Forms.Label lblNSport;
        private System.Windows.Forms.Label lblNSmoking;
        private System.Windows.Forms.Label lblShowMessage;
    }
}
