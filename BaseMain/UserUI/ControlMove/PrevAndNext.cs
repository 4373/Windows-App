using System;
using System.Drawing;
using System.Windows.Forms;

namespace BaseMain.UserUI.ControlMove
{
    public partial class PrevAndNext : UserControl
    {
        public event Action Next;
        public event Action Prev;
        public PrevAndNext()
        {
            InitializeComponent();
        }

        private string _rightString;

        public string RightString
        {
            get { return _rightString; }
            set { _rightString = value; }
        }

        //该控件改变时里面控件大小跟着变
        private void PrevAndNext_Resize(object sender, EventArgs e)
        {
            lblPrev.Size = new Size((int)(Width * 0.5), Height);
            lblNext.Size = new Size((int)(Width * 0.5), Height);
            lblNext.Location = new Point((int)(Width * 0.5), 0);
        }

        private void lblNext_Click(object sender, EventArgs e)
        {
            if (Next != null) Next();
        }      
        private void lblPrev_Click_1(object sender, EventArgs e)
        {
            if (Prev != null) Prev();
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

           


 

        private void lblNext_MouseUp(object sender, MouseEventArgs e)
        {
            lblNext.BackColor = Color.DarkTurquoise;
        }

        private void lblNext_MouseDown(object sender, MouseEventArgs e)
        {
            lblNext.BackColor = Color.DodgerBlue;
        }

        private void lblPrev_MouseUp(object sender, MouseEventArgs e)
        {
            lblPrev.BackColor = Color.Orange;
        }

        private void lblPrev_MouseDown(object sender, MouseEventArgs e)
        {
            lblPrev.BackColor = Color.DarkOrange;
        }

        private void PrevAndNext_Load(object sender, EventArgs e)
        {
            lblNext.Text = _rightString;
        }
    }
}
