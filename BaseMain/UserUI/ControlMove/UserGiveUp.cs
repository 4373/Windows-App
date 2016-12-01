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
    
    public partial class UserGiveUp : UserControl
    {
        public event Action GiveUpClik;
        public UserGiveUp()
        {
            InitializeComponent();
        }

        private void UserGiveUp_Click(object sender, EventArgs e)
        {
            if (GiveUpClik != null) GiveUpClik();
        }

        private void UserGiveUp_Resize(object sender, EventArgs e)
        {
            Height = 50*Width/134;
        }
    }
}
