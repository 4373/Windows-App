using System;
using System.Drawing;
using System.Windows.Forms;

namespace BaseMain.UserUI.CardSelect
{
    public partial class TwoSelection : UserControl
    {
        public event Action<string> TwoSelectionClik;
        public TwoSelection(string[] titleStrings, string[] contentStrings, float[] pro)
        {

            InitializeComponent();

            lblTitle1.Font = new Font(lblTitle1.Font.FontFamily, 40, FontStyle.Regular);
            lblTitle2.Font = new Font(lblTitle2.Font.FontFamily, 40, FontStyle.Regular);

            lblTitle1.Text = titleStrings[0];
            lblTitle2.Text = titleStrings[1];
            if (contentStrings != null)
            {
                lblContent1.Text = contentStrings[0];
                lblContent2.Text = contentStrings[1];
            }


            lblTitle1.Location = new Point(0, 0);
            if (1.0f != pro[0])
            {
                lblTitle1.Height = (int)(panel1.Height * pro[0]);
                lblContent1.Location = new Point(0, (int)(pro[0] * Height));
                lblContent1.Height = (int)(panel1.Height * (1 - pro[0])); ;
            }
            else
            {
                lblTitle1.Dock = DockStyle.Fill;
            }

            lblTitle2.Location = new Point(0, 0);
            if (1.0f != pro[1])
            {
                lblTitle2.Height = (int)(panel1.Height * pro[1]);
                lblContent2.Height = (int)(panel1.Height * (1 - pro[1])); ;
                lblContent2.Location = new Point(0, (int)(pro[1] * Height));
            }
            else
            {
                lblTitle2.Dock=DockStyle.Fill;
            }


       


            lblTitle1.BackColor = Color.Transparent;
            lblContent2.BackColor = Color.Transparent;
            lblTitle2.BackColor = Color.Transparent;
            lblContent1.BackColor = Color.Transparent;
        }

        private string _messageSelect;
        public TwoSelection()
        {
            InitializeComponent();
        }

        public string MessageSelect
        {
            get { return _messageSelect; }
            set { _messageSelect = value; }
        }

        //设置里面的panel大小
        private void SetSize()
        {
            panel1.Size = new Size(90 * Width / 280, 80 * Height / 120);
            panel2.Size = new Size(90 * Width / 280, 80 * Height / 120);

        }

        private void SetLocation()
        {
            panel1.Location = new Point(40 * Width / 280, 20 * Height / 120);
            panel2.Location = new Point(10 * Width / 280 + Width / 2, 20 * Height / 120);
        }

        private void TwoSelection_Resize(object sender, EventArgs e)
        {
            SetSize();
            SetLocation();
        }

        public void SetSize(int x, int y)
        {
            Width = x;
            Height = y;
        }

        public void SetLocation(int x, int y)
        {
            this.Location = new Point(x, y);
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            _messageSelect = "";
            panel1.BackColor = Color.DeepSkyBlue;
            panel2.BackColor = Color.White;
            _messageSelect = lblTitle1.Text + ((lblContent1.Text == string.Empty) || (lblContent1.Text == null) ? "" : ("@" + lblContent1.Text));
            if (TwoSelectionClik != null) TwoSelectionClik(_messageSelect);
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            _messageSelect = "";
            panel2.BackColor = Color.DeepSkyBlue;
            panel1.BackColor = Color.White;
            _messageSelect = lblTitle2.Text + ((lblContent2.Text == string.Empty) || (lblContent2.Text == null) ? "" : ("@" + lblContent2.Text));
            if (TwoSelectionClik != null) TwoSelectionClik(_messageSelect);
        }


    }
}
