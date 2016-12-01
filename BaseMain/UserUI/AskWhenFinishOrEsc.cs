using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaseMain.UserUI
{
    public partial class AskWhenFinishOrEsc : UserControl
    {
        public event Action OkClick;
        public event Action NotClick;

        private string _ask;
        private string _warning;
        public AskWhenFinishOrEsc()
        {
            InitializeComponent();
        }

        public string Ask
        {
            get { return _ask; }
            set { _ask = value; }
        }

        public string Warning
        {
            get { return _warning; }
            set { _warning = value; }
        }

        private void EscFromFillIn_Resize(object sender, EventArgs e)
        {
            lblPic.Height =(int) (0.30*Height);

            lblTitle.Size = new Size(Width, (int)(0.20 * Height));
            lblTitle.Location = new Point(0, (int)(0.35 * Height));
            lblTitle.Font=new Font(new FontFamily("幼圆"), (int)(lblTitle.Height*0.3) );

            lblContent.Size = new Size(Width, (int)(0.10 * Height));
            lblContent.Location = new Point(0, (int)(0.55 * Height));
            lblContent.Font=new Font(new FontFamily("幼圆"),(int)(lblContent.Height*0.4 ));

            lblNot.Size = new Size(Width / 2, (int)(0.15 * Height));
            lblNot.Location = new Point(0, (int)(0.85 * Height));
            lblNot.Font = new Font(new FontFamily("幼圆"), (int)(lblTitle.Height * 0.25));

            lblOk.Size = new Size(Width / 2, (int)(0.15 * Height));
            lblOk.Location = new Point(Width / 2, (int)(0.85 * Height));
            lblOk.Font = new Font(new FontFamily("幼圆"), (int)(lblTitle.Height * 0.25));
        }

        private void lblNot_MouseDown(object sender, MouseEventArgs e)
        {
            lblNot.BackColor = Color.Gray;
        }

        private void lblNot_MouseUp(object sender, MouseEventArgs e)
        {
            lblNot.BackColor = Color.LightSlateGray;
            if (NotClick != null) NotClick();
        }

        private void lblOk_MouseDown(object sender, MouseEventArgs e)
        {
            lblOk.BackColor = Color.DodgerBlue;

        }

        private void lblOk_MouseUp(object sender, MouseEventArgs e)
        {
            lblOk.BackColor = Color.DarkTurquoise;
            if (OkClick != null) OkClick();
        }

        private void EscFromFillIn_Load(object sender, EventArgs e)
        {
            lblTitle.Text = _ask;
            lblContent.Text = _warning;
        }
    }
}
