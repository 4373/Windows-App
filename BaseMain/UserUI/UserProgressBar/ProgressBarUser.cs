using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BaseMain.UserUI.ProgressBarParts;

namespace BaseMain.UserUI
{
    public partial class ProgressBarUser : UserControl
    {
        public event Action<int> ShowPage;
        



        private int _currentPage;
        private const int _count = 14;
        public ProgressBarUser()
        {
            InitializeComponent();
            this.AutoSize = false;
            
            SetPartsTags();

        }

        public ProgressBarUser(int a)
        {
            InitializeComponent();
            _currentPage = a;
            pbPicture1.Tags = a;
            SetPartsTags();
            SetSize();
            SetLocation();
            

        }

        private void SetPartsTags()
        {
            int i = 1;
            bool _b = true;
            foreach (var item in Controls)
            {
               
                if (item is PBCircle)
                {
                    var it = item as PBCircle;
                    if (i == _currentPage)
                    {
                        i++;
                        _b = false;
                    }
                    it.IsOn = _b;
                    it.Tags = i;
                    i++;
                }

            }
        }

        //当前进度,当前页面
        public int CurrentPage
        {
            get { return _currentPage; }
            set { _currentPage = value; }
        }



        //设置控件大小
        public void SetSize(int x, int y)
        {
            y++;
            while (x/y>10)
            {
                if (x/y<10)
                {
                    break;
                }
                y++;
            }
            this.Size = new Size(x, y);
        }
        //设置控件位子
        public void SetLocation(int x, int y)
        {
            this.Location = new Point(x, y);
        }

        private void ProgressBar_Resize(object sender, EventArgs e)
        {
            SetSize();
            SetLocation();

        }

        private void SetSize()
        {
            pbPicture1.SetSize(2 * Width / 17, 2 * Width / 17);
            foreach (var item in Controls)
            {
                if (item is PBCircle)
                {
                    var c = item as PBCircle;
                    c.SetSize(Width / 17, Width / 17);
                }
            }
        }

        private void SetLocation()
        {
            pbPicture1.SetLocation(Width / 17 * (_currentPage), Height / 2 - pbPicture1.Height / 2);
            foreach (var item in Controls)
            {
                if (item is PBCircle)
                {
                    var c = item as PBCircle;
                    if (c.Tags < _currentPage)
                    {
                        c.SetLocation(Width / 17 + (c.Tags - 1) * c.Width, Height / 2 - c.Height / 2);
                    }
                    else
                    {
                        c.SetLocation(_currentPage * Width / 17 + 2 * Width / 17 + (c.Tags - _currentPage - 1) * c.Width, Height / 2 - c.Height / 2);
                    }

                }
            }
        }

        private void pbCircle13_Cli(int obj)
        {
            if (ShowPage != null) ShowPage(obj);
        }
    }
}
