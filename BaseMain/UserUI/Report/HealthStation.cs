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
    public partial class HealthStation : UserControl
    {
        /// <summary>
        /// 血压
        /// </summary>
        public string BloodPressure { get; set; }
        /// <summary>
        /// 血糖
        /// </summary>
        public string BloodSugar { get; set; }
        /// <summary>
        /// 家族中风史
        /// </summary>
        public bool FamilyStroke { get; set; }
        /// <summary>
        /// 是否使用降压药
        /// </summary>
        public bool UseHypotensor { get; set; }
        /// <summary>
        /// 亲属糖尿病
        /// </summary>
        public bool BSugarHeredity { get; set; }
        /// <summary>
        /// 高胆固醇
        /// </summary>
        public bool HighCholesterol { get; set; }

        public HealthStation()
        {
            InitializeComponent();
          
        }


        private void HealthStation_Resize(object sender, EventArgs e)
        {
            lblTitle.Height = (int)(0.20 * Height);
            panel.Height = (int)(0.80 * Height);
            /////////////////////////////////名
            panelLName.Width = panel.Width / 2 * 70 / 250;
            //
            lblNBloodPre.Height = 100 * panelLName.Height / 450;
            lblNBloodSugar.Size = new Size(panelLName.Width, 200 * panelLName.Height / 450);
            lblNBloodSugar.Location = new Point(0, lblNBloodPre.Height);
            lblNFamilySt.Height = 150 * panelLName.Height / 450;


            ////////////////////////////////值
            panelLValue.Size = new Size(panel.Width / 2 * 180 / 250, panel.Height);
            panelLValue.Location = new Point(panelLName.Width, 0);
            //
            panel1.Height = 100 * panelLValue.Height / 450;//
            lblVBloodPre.Height = 2*panel1.Height/5;
            lblBPMessage.Height = 3 * panel1.Height / 5; 
            panel2.Size = new Size(panelLValue.Width, 200 * panelLValue.Height / 450);//
            panel2.Location = new Point(0, panel1.Height);//
            lblVBloodSugar.Height = 3 * panel2.Height / 10;
            lblBSMessage.Height = 7 * panel2.Height / 10;
            panel3.Height = 150 * panelLName.Height / 450;//
            cBoxFsYes.Location = new Point(1 * panel3.Width / 5, 3 * panel3.Height / 10);
            cBoxFsNo.Location = new Point(panel3.Width / 2, 3 * panel3.Height / 10);
            lblFamSMessage.Height = 2*panel3.Height/5;

            /////////////////////////////////名
            panelRName.Size = panelLName.Size;
            panelRName.Location = new Point(panelLName.Width + panelLValue.Width, 0);
            //
            lblNUseMecin.Height = 100 * panelRName.Height / 450;
            lblNFamBloSu.Size = new Size(panelRName.Width, 200 * panelRName.Height / 450);
            lblNFamBloSu.Location = new Point(0, lblNUseMecin.Height);
            lblNhighC.Height = 150 * panelRName.Height / 450;

            /////////////////////////////////值
            panelRValue.Width = panel.Width / 2 * 180 / 250;
            //
            panel1r.Height = 100 * panelRValue.Height / 450;//
            cBoxUseMYes.Location = new Point(3 * panel1r.Width / 10, 2 * panel1r.Height / 5);
            cBoxUseMNo.Location = new Point( 6*panel1r.Width / 10, 2 * panel1r.Height / 5);
            panel2r.Size = new Size(panelRValue.Width, 200 * panelRValue.Height / 450);//
            panel2r.Location = new Point(0, panel1r.Height);//
            cBoxFamBSYes.Location = new Point(3 * panel2r.Width / 10, 2 * panel2r.Height / 5);
            cBoxFamBSNo.Location = new Point(6 * panel1r.Width / 10, 2 * panel2r.Height / 5);
            panel3r.Height = 150 * panelRValue.Height / 450;//
            cBoxHighCYes.Location = new Point(3 * panel3r.Width / 10, 1 * panel3r.Height / 10);
            cBoxHighCNo.Location = new Point(6 * panel3r.Width / 10, 1 * panel3r.Height / 10);
            lblHighCMessage.Height = 6*panel3r.Height/10;
        }

        private void HealthStation_Load(object sender, EventArgs e)
        {
            lblVBloodPre.Text = BloodPressure;
            lblVBloodSugar.Text = BloodSugar;
            if (FamilyStroke)
            {
                cBoxFsYes.Checked = true;
                cBoxFsNo.Checked = false;
            }
            else
            {
                cBoxFsYes.Checked = false;
                cBoxFsNo.Checked = true;
            }
            if (UseHypotensor)
            {
                cBoxUseMYes.Checked = true;
                cBoxUseMNo.Checked = false;
            }
            else
            {
                cBoxUseMYes.Checked = false;
                cBoxUseMNo.Checked = true;
            }
            if (BSugarHeredity)
            {
                cBoxFamBSYes.Checked = true;
                cBoxFamBSNo.Checked = false;
            }
            else
            {
                cBoxFamBSYes.Checked = false;
                cBoxFamBSNo.Checked = true;
            }
            if (HighCholesterol)
            {
                cBoxHighCYes.Checked = true;
                cBoxHighCNo.Checked = false;
            }
            else
            {
                cBoxHighCYes.Checked = false;
                cBoxHighCNo.Checked = true;
            }
        }


    }
}
