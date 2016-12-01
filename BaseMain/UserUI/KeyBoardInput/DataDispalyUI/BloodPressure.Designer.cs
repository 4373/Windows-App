namespace BaseMain.UserUI.DataDispalyUI
{
    partial class BloodPressure
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
            this.lblH = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblHg = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblL = new System.Windows.Forms.Label();
            this.lblLg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblH
            // 
            this.lblH.Font = new System.Drawing.Font("幼圆", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblH.Location = new System.Drawing.Point(75, 59);
            this.lblH.Name = "lblH";
            this.lblH.Size = new System.Drawing.Size(86, 35);
            this.lblH.TabIndex = 7;
            this.lblH.Text = "高压";
            this.lblH.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("幼圆", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox1.ForeColor = System.Drawing.Color.Gray;
            this.textBox1.Location = new System.Drawing.Point(167, 55);
            this.textBox1.MaxLength = 5;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 39);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // lblHg
            // 
            this.lblHg.Font = new System.Drawing.Font("幼圆", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblHg.Location = new System.Drawing.Point(273, 57);
            this.lblHg.Name = "lblHg";
            this.lblHg.Size = new System.Drawing.Size(78, 35);
            this.lblHg.TabIndex = 9;
            this.lblHg.Text = "mmHg";
            this.lblHg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Font = new System.Drawing.Font("幼圆", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox2.ForeColor = System.Drawing.Color.Gray;
            this.textBox2.Location = new System.Drawing.Point(560, 55);
            this.textBox2.MaxLength = 5;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 39);
            this.textBox2.TabIndex = 2;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // lblL
            // 
            this.lblL.Font = new System.Drawing.Font("幼圆", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblL.Location = new System.Drawing.Point(475, 59);
            this.lblL.Name = "lblL";
            this.lblL.Size = new System.Drawing.Size(79, 35);
            this.lblL.TabIndex = 10;
            this.lblL.Text = "低压";
            this.lblL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLg
            // 
            this.lblLg.Font = new System.Drawing.Font("幼圆", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblLg.Location = new System.Drawing.Point(666, 59);
            this.lblLg.Name = "lblLg";
            this.lblLg.Size = new System.Drawing.Size(74, 35);
            this.lblLg.TabIndex = 11;
            this.lblLg.Text = "mmHg";
            this.lblLg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BloodPressure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblLg);
            this.Controls.Add(this.lblL);
            this.Controls.Add(this.lblHg);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lblH);
            this.Controls.Add(this.textBox1);
            this.Name = "BloodPressure";
            this.Size = new System.Drawing.Size(804, 150);
            this.Resize += new System.EventHandler(this.BloodPressure_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblH;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblHg;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblL;
        private System.Windows.Forms.Label lblLg;
    }
}
