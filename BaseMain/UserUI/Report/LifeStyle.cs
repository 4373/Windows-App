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
    public partial class LifeStyle : UserControl
    {
        public LifeStyle()
        {
            InitializeComponent();
           
        }

        public bool Smoking { get; set; }
        public bool Sport { get; set; }

        private void LifeStyle_Resize(object sender, EventArgs e)
        {
            lblTitle.Height = (int)(0.20 * Height);
            panel1.Height = (int)(0.80 * Height);

            lblNSmoking.Width = (panel1.Width / 2 * 70 / 250);
           panelsmoke.Size = new Size(panel1.Width/2*180/250, panel1.Height);
            panelsmoke.Location = new Point(panel1.Width / 2 * 70 / 250, 0);
            
            panelsmoke.BringToFront();
            
            cBoxSmokeYes.Location = new Point(panelsmoke.Width / 2 - cBoxSmokeYes.Width, panelsmoke.Height / 2);
            cBoxSmokeNo.Location = new Point(panelsmoke.Width / 2, panelsmoke.Height / 2);

            lblNSport.Size = new Size(panel1.Width / 2 * 70 / 250,panel1.Height);
            lblNSport.Location=new Point(panel1.Width/2,0);

            panelSport.Width =  panel1.Width/2*180/250;
            panelSport.BringToFront();
            lblShowMessage.Height =(int)( panelSport.Height*0.6);
            cBoxSportYes.Location = new Point(panelSport.Width / 2 - cBoxSportYes.Width, (int)(panelSport.Height * 0.4 / 2));
            cBoxSportNo.Location = new Point(panelSport.Width / 2 , (int)(panelSport.Height * 0.4 / 2));


            // var nameSize = new Size((int)(panel1.Width / 2 * 70 / 250), panel1.Height / 4);
            //var valueSize = new Size((int)(panel1.Width / 2 * 180 / 250), panel1.Height / 4);
        }

        private void LifeStyle_Load(object sender, EventArgs e)
        {
            if (Smoking)
            {
                cBoxSmokeYes.Checked = true;
                cBoxSmokeNo.Checked = false;
            }
            else
            {
                cBoxSmokeYes.Checked = false;
                cBoxSmokeNo.Checked = true;
            }
            if (Sport)
            {
                cBoxSportYes.Checked = true;
                cBoxSportNo.Checked = false;
            }
            else
            {
                cBoxSportYes.Checked = false;
                cBoxSportNo.Checked = true;
            }
        }
    }
}
