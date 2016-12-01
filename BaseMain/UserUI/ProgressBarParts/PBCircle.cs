using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace BaseMain.UserUI.ProgressBarParts
{
    public partial class PBCircle : UserControl
    {
        public PBCircle()
        {
            
            InitializeComponent();
        }

        public event Action<int> Cli;
        private bool _isOn;
        private int _tags;
        public bool IsOn
        {
            get { return _isOn; }
            set { _isOn = value; }
        }

        public int Tags
        {
            get { return _tags; }
            set { _tags = value; }
        }


        protected override void OnPaint(PaintEventArgs e)
        {
            var p = e.Graphics;
            p.SmoothingMode = SmoothingMode.AntiAlias;  //使绘图质量最高，即消除锯齿
            p.InterpolationMode = InterpolationMode.HighQualityBicubic;
            p.CompositingQuality = CompositingQuality.HighQuality;
            p.DrawEllipse(new Pen(Color.DarkGray), new Rectangle(Width / 5, Width / 5, 3 * Width / 5, 3* Width / 5));
            p.FillEllipse(_isOn ? new SolidBrush(Color.DodgerBlue) : new SolidBrush(Color.White),
                new Rectangle(Width / 5, Width / 5, 3 * Width / 5, 3 * Width / 5));
         
        }


        private void PBCircle_Resize(object sender, EventArgs e)
        {
            Height = Width;
            Invalidate();
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

        private void PBCircle_Click(object sender, EventArgs e)
        {
            if (Cli != null) Cli(this._tags);
            Invalidate();
        }
    }
}
