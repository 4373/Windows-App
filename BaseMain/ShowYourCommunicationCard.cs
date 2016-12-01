using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using BaseMain.Common;

namespace BaseMain
{
    public partial class ShowYourCommunicationCard : Form
    {
        private FrmMain fm;
        public ShowYourCommunicationCard()
        {
            InitializeComponent();
            label1.ForeColor = Color.CornflowerBlue;
        }

        private Patient patient;
        private int i;
        private void ShowYourCommunicationCard_Load(object sender, EventArgs e)
        {
            timer.Start();
            Patient p = new Patient
            {
                PBarCode = 0000000000,
                PName = "梅欢",
                PNo = 000000
            };
            patient = p;

        }

        private void ShowYourCommunicationCard_Resize(object sender, EventArgs e)
        {
            title1.Size = new Size(Width, (int)(Height * 0.25));
            label1.Size = new Size(4 * Width / 5, (int)(0.30 * Height));
            label1.Location = new Point(Width / 10, (int)(0.2 * Height));
            label1.Font = new Font(new FontFamily("幼圆"), (int)(Height * 0.03));
            panel1.Location = new Point(0, Height / 2);
            panel1.Size = new Size(Width, 3 * Height / 7);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (i == 50)
            {
                FrmMain f = new FrmMain(patient); 
                f.Opacity = 0.0;
                f.Show();
                timer.Stop();
                i = 0;
                fm = f;
                timer1.Start();
                return;

            }
            i++;
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            fm.Opacity += 0.2;
            if (fm.Opacity == 1.0)
            {
                timer1.Stop();
                this.Close();
            }
        }
    }
}
