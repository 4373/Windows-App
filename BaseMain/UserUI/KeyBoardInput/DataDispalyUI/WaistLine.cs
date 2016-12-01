using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaseMain.UserUI.DataDispalyUI
{
    public partial class WaistLine : UserControl
    {
        public WaistLine()
        {
            InitializeComponent();
        }

        
        public void SetText(string str)
        {
            var t1 = textBox1.Text;
            var t2 = textBox2.Text;
            if (t1==string.Empty)
            {
                textBox1.Text = str;
                return;
            }
            if (t1!=string.Empty&&t2==string.Empty&&str!=string.Empty)
            {
                textBox2.Text = str;
                return;
            }
            if (str==string.Empty&&t2!=string.Empty)
            {
                textBox2.Text = str;
                return;
            }
            if (str==string.Empty&&t1!=string.Empty)
            {
                textBox1.Text = str;
                
            }
        }

        public string GetText()
        {
            if (textBox1.Text == string.Empty || textBox2.Text==string.Empty)
            {
                return string.Empty;
            }
            return textBox1.Text + "尺" + textBox2.Text + "寸";
        }
        private void SetSize()
        {
            Size sizes=new Size(this.Width*30/230,this.Height*2/3);
            label1.Size = sizes;
            label2.Size = sizes;
            textBox1.Size = sizes;
            textBox2.Size = sizes;
        }

        private void SetLocation()
        {
            label1.Location = new Point(Width / 2 - textBox1.Width- label1.Width,  Height / 2-label1.Height/2);
            textBox1.Location = new Point(Width / 2 - textBox1.Width, Height / 2 - textBox1.Height / 2);
            label2.Location = new Point(Width / 2 , Height / 2 - label2.Height / 2);
            textBox2.Location = new Point(Width / 2 + label2.Width , Height / 2 - textBox2.Height / 2);
        }

        private void WaistLine_Resize(object sender, EventArgs e)
        {
            SetSize();
            SetLocation();
        }
        //设置控件大小
        public void SetSize(int x, int y)
        {
            this.Size = new Size(x, y);
        }

        //设置控件位子
        public void SetLocation(int x, int y)
        {
            this.Location = new Point(x, y);
        }
    }
}
