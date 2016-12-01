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
    public partial class Title : UserControl
    {
        private string _title;

        public string title
        {
            set
            {
                _title = value;
                label1.Text = _title;
            }
            get { return _title; }
        }

        public Title()
        {
           
            InitializeComponent();

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
