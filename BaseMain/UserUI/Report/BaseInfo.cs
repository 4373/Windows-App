using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaseMain.UserUI.Report
{
    public partial class BaseInfo : UserControl
    {
        public BaseInfo()
        {
            InitializeComponent();
           

        }

        public string BaseId { get; set; }
        public string BaseName { get; set; }
        public string BaseAge { get; set; }
        public string BaseWaist { get; set; }
        public string BaseHeight { get; set; }
        public string BaseWeight { get; set; }
        public string BaseTime { get; set; }
        public string BaseSex { get; set; }
        private void BaseInfo_Resize(object sender, EventArgs e)
        {
            lblTitle.Height =(int) ( 0.20*Height);
            panel1.Height = (int) (0.80*Height);

            var nameSize = new Size((int)(panel1.Width / 2 * 70 / 250), panel1.Height / 4);
            var valueSize = new Size((int)(panel1.Width / 2 * 180 / 250), panel1.Height / 4);

            lblNId.Size = nameSize;
            lblNAge.Size = nameSize;
            lblNHeight.Size = nameSize;
            lblNWaist.Size = nameSize;
            lblNDataTime.Size = nameSize;
            lblNSex.Size = nameSize;
            lblNWeight.Size = nameSize;
            lblNName.Size = nameSize;

            lblVId.Size = valueSize;
            lblVAge.Size = valueSize;
            lblVHeight.Size = valueSize;
            lblVWaist.Size = valueSize;
            lblVDatatime.Size = valueSize;
            lblVSex.Size = valueSize;
            lblVWeight.Size = valueSize;
            lblVName.Size = valueSize;

            lblNId.Location=new Point(0,0);
            lblVId.Location=new Point(lblNId.Width,0);
            lblNDataTime.Location=new Point(lblNId.Width+lblVId.Width,0);
            lblVDatatime.Location=new Point(2*lblNId.Width+lblVId.Width,0);

            lblNAge.Location=new Point(0,1*panel1.Height/4);
            lblVAge.Location=new Point(lblNId.Width,1*panel1.Height/4);
            lblNSex.Location = new Point(lblNId.Width + lblVId.Width, 1 * panel1.Height / 4);
            lblVSex.Location = new Point(2 * lblNId.Width + lblVId.Width, 1 * panel1.Height / 4);

            lblNHeight.Location =new Point(0,2*panel1.Height/4);
            lblVHeight.Location=new Point(lblNId.Width,2*panel1.Height/4);
            lblNWeight.Location =new Point(lblNId.Width + lblVId.Width,2*panel1.Height/4);
            lblVWeight.Location = new Point(2 * lblNId.Width + lblVId.Width, 2 * panel1.Height / 4);

            lblNWaist.Location=new  Point(0,3*panel1.Height/4);
            lblVWaist.Location=new Point(lblNId.Width,3*panel1.Height/4);
            lblNName.Location=new Point(lblNId.Width + lblVId.Width,3*panel1.Height/4);
            lblVName.Location = new Point(2 * lblNId.Width + lblVId.Width, 3 * panel1.Height / 4);

            foreach (var item in panel1.Controls)
            {
                if (item is Label)
                {
                    var label = item as Label;
                    label.Font = new Font(new FontFamily("微软雅黑"),16);
                }
            }
            
        }

        private void BaseInfo_Load(object sender, EventArgs e)
        {
            lblVId.Text = BaseId;
            lblVName.Text = BaseName;
            lblVAge.Text = BaseAge;
            lblVWaist.Text = BaseWaist;
            lblVWeight.Text = BaseWeight;
            lblVHeight.Text = BaseHeight;
            lblVDatatime.Text = BaseTime;
            lblVSex.Text = BaseSex;
        }
    }
}
