using System;
using System.Drawing;
using System.Windows.Forms;

namespace BaseMain.UserUI.DataDispalyUI
{
    public partial class BloodPressure : UserControl
    {
        public BloodPressure()
        {
            InitializeComponent();
        }

        private string _message;
        /// <summary>
        /// 得到里面的数据
        /// </summary>
        /// <returns>显示的数据</returns>
        public string GetText()
        {
            if (textBox1.Text == string.Empty || textBox2.Text == string.Empty)
            {
                return string.Empty;
            }
            return _message;
        }

        /// <summary>
        /// 设置要先显示的数据,只能单个字符输入,否则可能会报错
        /// </summary>
        /// <param name="str">要输入的字符</param>
        public void SetTextOLD(string str)
        {
            
            var t1 = textBox1.Text;
            var t2 = textBox2.Text;
            if (t1.Length<3&&str!=string.Empty)
            {
                textBox1.Text += str;
                return;
            }
             if (t1.Length==3&&t2.Length<3&&str!=string.Empty)
            {
                textBox2.Text += str;
                return;
            }
             if (str == string.Empty && t2 != string.Empty)
            {
                textBox2.Text = t2.Remove(t2.Length - 1, 1);
                return;
            }
             if(str==string.Empty&&t2==string.Empty&&t1!=string.Empty)
            {
                textBox1.Text = t1.Remove(t1.Length - 1, 1);
            }

        }


        public void SetText(string str)
        {
            var t1 = textBox1.Text;
            var t2 = textBox2.Text;
            if (str!=string.Empty)
            {
                if (!textBox2.Focused&&textBox1.Text.Length<=2)
                {
                    textBox1.Text = t1 + str;
                    //
                    if (textBox1.Text.Length==3)
                    {
                        textBox2.Focus();
                    }
                    return;
                }
                if (textBox2.Focused&&textBox2.Text.Length<=2)
                {
                    textBox2.Text = t2 + str;
                    //
                    if (textBox2.Text.Length == 3)
                    {
                        textBox1.Focus();
                    }
                    
                }
            }
            else
            {

                if (textBox1.Focused&&t1!=string.Empty)
                {
                    textBox1.Text = t1.Remove(t1.Length - 1, 1);
                    //
                    if (textBox1.Text ==string.Empty)
                    {
                        textBox2.Focus();
                    }
                    
                    return;
                }
                if (textBox2.Focused && t2 != string.Empty)
                {
                    textBox2.Text = t2.Remove(t2.Length - 1, 1);
                    //
                    if (textBox2.Text == string.Empty)
                    {
                        textBox1.Focus();
                    }
                    
                }
            }
        }
        private void SetSize()
        {
            var sizes =new Size(Width/8,Height*2/3);
            lblH.Size = sizes;
            lblHg.Size = sizes;
            lblL.Size = sizes;
            lblLg.Size = sizes;
            textBox1.Size = sizes;
            textBox2.Size = sizes;
        }

        private void SetLocation()
        {
            lblH.Location = new Point(Width / 2 - 3 * lblH.Width, Height / 2 - lblH.Height / 2);
            textBox1.Location = new Point(Width / 2 - 2* lblH.Width, Height / 2 - textBox1.Height / 2);
            lblHg.Location = new Point(Width / 2 - 1* lblH.Width, Height / 2 - lblH.Height / 2);

            lblL.Location = new Point(Width / 2, Height / 2 - lblH.Height / 2);
            textBox2.Location = new Point(Width / 2 + 1 * lblH.Width, Height / 2 - textBox1.Height / 2);
            lblLg.Location = new Point(Width / 2 + 2 * lblH.Width, Height / 2 - lblH.Height / 2);

        }

        private void BloodPressure_Resize(object sender, EventArgs e)
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            _message = textBox1.Text + "@" + textBox2.Text;
        }
    }
}
