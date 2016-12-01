using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace BaseMain.UserUI
{
    public partial class Number : UserControl
    {
        public event Action<string> SetText;
        public event Action Clears;
        public Number(string number)
        {
            InitializeComponent();
            label1.BackColor = Color.Transparent;
            label1.Text = number;
        }

    

        public void SetFontSize(int size)
        {
            label1.Font = new Font(label1.Font.FontFamily, size, label1.Font.Style);
        }
        private bool _isMouseDown=true;
        protected override void OnPaint(PaintEventArgs e)
        {
            var g= e.Graphics;
            var pen=new Pen(Color.LightGray);
            var rect = new Rectangle(0, 0, Width-2, Width-2);
            var sbrush = new SolidBrush(Color.DodgerBlue);
            g.DrawEllipse(pen,rect);
            g.SmoothingMode = SmoothingMode.AntiAlias;  //使绘图质量最高，即消除锯齿
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            g.CompositingQuality = CompositingQuality.HighQuality;
            if (!_isMouseDown)
            {
                g.FillEllipse(sbrush,rect);
            }
            
        }

        private void label1_MouseUp(object sender, MouseEventArgs e)
        {
            _isMouseDown = true;
            Invalidate();
            if (label1.Text!="清除")
            {
                if (SetText != null)
                {
                    SetText(label1.Text);
                   
                }
            }
            else
            {
                if (Clears != null) Clears();
            }
         
        }

        public void SetSize(int x,int y)
        {
            this.Size=new Size(x,y);
        }

        public void SetLocation(int x, int y)
        {
            this.Location=new Point(x,y);
        }
        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            _isMouseDown = false;
            Invalidate();
        }

        private void Number_Resize(object sender, EventArgs e)
        {
            Width = Height;
            Height = Width;
        }
    }
}
