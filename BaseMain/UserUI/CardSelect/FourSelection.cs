using System;
using System.Drawing;
using System.Windows.Forms;

namespace BaseMain.UserUI.CardSelect
{
    public partial class FourSelection : UserControl
    {
        public FourSelection()
        {
            InitializeComponent();
        }

        public event Action<string> FourSelectClik;
        /// <summary>
        /// 选择的信息
        /// </summary>
        private string _messageSelect;
        /// <summary>
        /// 构造自定实例
        /// </summary>
        /// <param name="titles">选择卡的大标题,不可为空</param>
        /// <param name="contens">选择卡内容,可为空</param>
        /// <param name="pro">标题高与panel高的比例,最大为1,此时panel内没有内容</param>
        public FourSelection(string[] titles, string[] contens, float[] pro)
        {
            InitializeComponent();
            //panel1
            lblTitle1.Text = titles[0];
            lblContent1.Text = contens==null? "":contens[0];
            if (1.0f!=pro[0])
            {
                 lblTitle1.Height = (int)(panel1.Height*pro[0]);
            lblContent1.Height = (int)(panel1.Height *(1- pro[0]));
            }
            else
            {
                lblTitle1.Dock=DockStyle.Fill;
            }
           

            //panel2
            lblTitle2.Text = titles[1];
            lblContent2.Text = contens == null ? "" : contens[1];
            if (1.0f!=pro[1])
            {
                   lblTitle2.Height = (int)(panel2.Height * pro[1]);
                lblContent2.Height = (int) (panel2.Height*(1 - pro[1]));
            }
            else
            {
                lblTitle2.Dock=DockStyle.Fill;
            }
         

            //panel3
            lblTitle3.Text = titles[2];
            lblContent3.Text = contens == null ? "" : contens[2];
            if (1.0f!=pro[2])
            {
                lblTitle3.Height = (int)(panel3.Height * pro[2]);
            lblContent3.Height = (int)(panel3.Height * (1 - pro[2]));
            }
            else
            {
                lblTitle3.Dock=DockStyle.Fill;
            }

            //panel4
            lblTitle4.Text = titles[3];
            lblContent4.Text = contens == null ? "" : contens[3];
            if (1.0f!=pro[3])
            {
                  lblTitle4.Height = (int)(panel4.Height * pro[3]);
            lblContent4.Height = (int)(panel4.Height * (1 - pro[3]));
            }
            else
            {
                lblTitle4.Dock=DockStyle.Fill;
            }
          

            //label全透明
            lblTitle1.BackColor = Color.Transparent;
            lblTitle2.BackColor = Color.Transparent;
            lblTitle3.BackColor = Color.Transparent;
            lblTitle4.BackColor = Color.Transparent;
            lblContent1.BackColor = Color.Transparent;
            lblContent2.BackColor = Color.Transparent;
            lblContent3.BackColor = Color.Transparent;
            lblContent4.BackColor = Color.Transparent;
        }

        public string MessageSelect
        {
            get { return _messageSelect; }
            set { _messageSelect = value; }
        }

        /// <summary>
        /// 设置该控件里面的控件大小
        /// </summary>
        private void SetSize()
        {
            panel1.Size = new Size(90 * Width / 280, 52 * Height / 120);
            panel2.Size = new Size(90 * Width / 280, 52 * Height / 120);
            panel3.Size = new Size(90 * Width / 280, 52 * Height / 120);
            panel4.Size = new Size(90 * Width / 280, 52 * Height / 120);
        }

        /// <summary>
        /// 设置该控件里面的控件位子
        /// </summary>
        private void SetLocation()
        {
            panel1.Location = new Point(40 * Width / 280, 5 * Height / 120);
            panel2.Location = new Point(10 * Width / 280 + Width / 2, 5 * Height / 120);
            panel3.Location = new Point(40 * Width / 280, Height / 2);
            panel4.Location = new Point(10 * Width / 280 + Width / 2, Height / 2);
        }

        /// <summary>
        /// 设置该控件的大小
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public void SetSize(int x, int y)
        {
            this.Size=new Size(x,y);
        }
        /// <summary>
        /// 设置该控件的位子
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public void SetLocation(int x, int y)
        {
            this.Location=new Point(x,y);
        }
        private void FourSelection_Resize(object sender, EventArgs e)
        {
            SetLocation();
            SetSize();
        }


        //第一个选择卡点击事件
        private void lblContent1_Click(object sender, EventArgs e)
        {
            _messageSelect = "";
            panel1.BackColor = Color.DeepSkyBlue;
            panel2.BackColor = Color.White;
            panel3.BackColor = Color.White;
            panel4.BackColor = Color.White;
            _messageSelect = lblTitle1.Text + (lblContent1.Text == "" ? string.Empty : ("@" + lblContent1.Text));
            if (FourSelectClik != null) FourSelectClik(_messageSelect);
        }

        //第二个选择卡点击事件
        private void lblTitle2_Click(object sender, EventArgs e)
        {
            _messageSelect = "";
            panel2.BackColor = Color.DeepSkyBlue;
            panel1.BackColor = Color.White;
            panel3.BackColor = Color.White;
            panel4.BackColor = Color.White;
            _messageSelect = lblTitle2.Text + (lblContent2.Text == "" ? string.Empty : ("@" + lblContent2.Text));
            if (FourSelectClik != null) FourSelectClik(_messageSelect);
        }

        //第三个选择卡点击事件
        private void lblTitle3_Click(object sender, EventArgs e)
        {
            _messageSelect = "";
            panel3.BackColor = Color.DeepSkyBlue;
            panel2.BackColor = Color.White;
            panel1.BackColor = Color.White;
            panel4.BackColor = Color.White;
            _messageSelect = lblTitle3.Text + (lblContent3.Text == "" ? string.Empty : ("@" + lblContent3.Text));
            if (FourSelectClik != null) FourSelectClik(_messageSelect);
        }

        //第四个选择卡点击事件
        private void lblTitle4_Click(object sender, EventArgs e)
        {
            _messageSelect = "";
            panel4.BackColor = Color.DeepSkyBlue;
            panel2.BackColor = Color.White;
            panel3.BackColor = Color.White;
            panel1.BackColor = Color.White;
            _messageSelect = lblTitle4.Text + (lblContent4.Text == "" ? string.Empty : ("@" + lblContent4.Text));
            if (FourSelectClik != null) FourSelectClik(_messageSelect);
        }

    }
}
