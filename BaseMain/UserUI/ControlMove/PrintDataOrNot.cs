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
    public partial class PrintDataOrNot : UserControl
    {
        public PrintDataOrNot()
        {
            InitializeComponent();
        }

        private static bool _isPrint;


        public event Action PrintEvent;
        public event Action NotPrintEvent;


        private void lblGiveUp_MouseUp_1(object sender, MouseEventArgs e)
        {
            _isPrint = false;
            if (NotPrintEvent != null)
                NotPrintEvent();
            lblGiveUp.BackColor = Color.LightSlateGray;
        }

        private void lblGiveUp_MouseDown_1(object sender, MouseEventArgs e)
        {
            lblGiveUp.BackColor = Color.DimGray;
        }

        private void lblAgree_MouseUp_1(object sender, MouseEventArgs e)
        {
            lblPrint.BackColor = Color.DeepSkyBlue;
            _isPrint = true;
            if (PrintEvent != null)
                PrintEvent();
        }

        private void lblAgree_MouseDown_1(object sender, MouseEventArgs e)
        {
            lblPrint.BackColor = Color.DodgerBlue;
        }

        private void PrintDataOrNot_Resize(object sender, EventArgs e)
        {
            lblPrint.Size = new Size((int)(Width * 0.6), Height);
            lblGiveUp.Size = new Size((int)(Width * 0.4), Height);
            lblPrint.Location = new Point((int)(Width * 0.4), 0);
        }
    }
}
