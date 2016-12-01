using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaseMain
{
    public partial class FrmEscOrFinishGiveUp : Form
    {
        public string YesOrNo = string.Empty;
        public event Action ClicYseOrNo;
        public FrmEscOrFinishGiveUp(string ask,string warning)
        {
            InitializeComponent();
            //DrawToBitmap
            escFromFillIn1.Ask = ask;
            escFromFillIn1.Warning = warning;
            escFromFillIn1.NotClick += escFromFillIn1_NotClick;
            escFromFillIn1.OkClick += escFromFillIn1_OkClick;
        }

        void escFromFillIn1_OkClick()
        {
            DialogResult=DialogResult.OK;
            YesOrNo = "OK";
            if (ClicYseOrNo != null) ClicYseOrNo();
        }

        void escFromFillIn1_NotClick()
        {
            DialogResult=DialogResult.Cancel;
            YesOrNo = "NO";
            if (ClicYseOrNo != null) ClicYseOrNo();
        }

        private void FrmEsc_Resize(object sender, EventArgs e)
        {
            panel1.Location = new Point(Width / 2 - panel1.Width/2, Height / 2 - panel1.Height/2);
        }


    }
}
