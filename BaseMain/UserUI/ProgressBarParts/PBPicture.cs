using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaseMain.UserUI.ProgressBarParts
{
    public partial class PBPicture : UserControl
    {
        public PBPicture()
        {
            InitializeComponent();
        }

        private int _tags;

        public int Tags
        {
            get { return _tags; }
            set { _tags = value; }
        }


        //设置控件大小
        public void SetSize(int x, int y)
        {
            this.Size = new Size(x, y);
        }
        //设置控件位子
        public void SetLocation(int x, int y)
        {
            this.Location = new Point(x , y);
        }

        private void PBPicture_Resize(object sender, EventArgs e)
        {
            Width = Height;
            panel1.Size=new Size(3*Width/5,3*Height/5);
            panel1.Location=new Point(Width/5,Height/5);
        }

  
    }
}
