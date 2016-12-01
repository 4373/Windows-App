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
    public partial class HeightData : UserControl
    {

        public HeightData()
        {
            InitializeComponent();
        }



        //提供数据
        public string GetText()
        {
            return textBox1.Text;
        }
        //得到数据
        public void SetText(string str)
        {
            string t = textBox1.Text;
            if (str==string.Empty&&t.Length!=0)
            {
                textBox1.Text = t.Remove(t.Length - 1, 1);
            }
            if (t.Length==3)
            {
                return;
            }
            textBox1.Text += str;

        }

        private void SetSize()
        {
            textBox1.Size = new Size(40 * Width / 230, 20 * Height / 30);
            label1.Size = new Size(48 * Width / 230, 20 * Height / 30);
        }

        private void SetLacation()
        {
            textBox1.Location = new Point(Width / 2 - textBox1.Width, Height / 2 - textBox1.Height / 2);
            label1.Location = new Point(Width / 2, Height/2-label1. Height / 2);
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




        private void HeightData_Resize(object sender, EventArgs e)
        {
            SetSize();
            SetLacation();
        }
    }
}

