using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaseMain.UserUI.ControlMove
{
    public partial class OnlyNext : UserControl
    {
        public event Action Next;
        public OnlyNext()
        {
            InitializeComponent();
        }

        private void lblNext_MouseDown(object sender, MouseEventArgs e)
        {
            lblNext.BackColor = Color.DodgerBlue;
        }

        private void lblNext_MouseUp(object sender, MouseEventArgs e)
        {
            lblNext.BackColor = Color.DarkTurquoise;
        }

        private void lblNext_Click(object sender, EventArgs e)
        {
            Next();
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
