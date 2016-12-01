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
    public partial class AgreeOrNot : UserControl
    {
        public static bool _isAgree;

        public AgreeOrNot()
        {
            InitializeComponent();
        }
        public  event  Action AgreeEvent;
        public  event  Action NotAgreeEvent;

        private void AgreeOrNotButton_Resize(object sender, EventArgs e)
        {
            lblAgree.Size = new Size((int)(Width * 0.6), Height);
            lblGiveUp.Size=new Size((int)(Width*0.4),Height);
            lblAgree.Location = new Point((int) (Width*0.4), 0);
        }

        private void lblGiveUp_Click(object sender, EventArgs e)
        {
            _isAgree = false;
            if (NotAgreeEvent != null)
                NotAgreeEvent();
        }

        private void lblAgree_Click(object sender, EventArgs e)
        {
            _isAgree = true;
            if (AgreeEvent != null) 
                AgreeEvent();
        }

        private void lblAgree_MouseDown(object sender, MouseEventArgs e)
        {
            lblAgree.BackColor = Color.LightSeaGreen;
        }

        private void lblAgree_MouseUp(object sender, MouseEventArgs e)
        {
            lblAgree.BackColor = Color.DarkTurquoise;
        }

        private void lblGiveUp_MouseUp(object sender, MouseEventArgs e)
        {
            lblGiveUp.BackColor = Color.LightSlateGray;
        }

        private void lblGiveUp_MouseDown(object sender, MouseEventArgs e)
        {
            lblGiveUp.BackColor = Color.DimGray;
        }
    }
}
