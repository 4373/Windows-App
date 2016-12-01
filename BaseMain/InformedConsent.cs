using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BaseMain.UserUI;

namespace BaseMain
{
    public partial class InformedConsent : Form
    {
        ShowYourCommunicationCard o;
        public InformedConsent()
        {
            InitializeComponent();
            WindowState= FormWindowState.Maximized;
            
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            agreeOrNot1.Size = new Size(Width, (int) (Height*0.12));
            richTextBox1.Location = new Point((int) (Width*0.1), (int) (Height*0.15));
            richTextBox1.Size = new Size((int)(Width*0.8),(int)(Height*0.7));
            label3.Size = new Size(Width, (int)(Height * 0.14));
        }

        private void agreeOrNot1_AgreeEvent()
        {
            ShowYourCommunicationCard s =new ShowYourCommunicationCard();
            s.WindowState = FormWindowState.Maximized;
            s.Opacity = 0;
            s.Show();
            o = s;
            timer1.Start();
            //this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            o.Opacity += 0.2;
            if (o.Opacity==1.0)
            {
                timer1.Stop();
            }
        }
    }
}
