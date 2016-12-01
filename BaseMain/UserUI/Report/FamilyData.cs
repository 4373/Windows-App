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
    public partial class FamilyData : UserControl
    {
        public FamilyData()
        {
            InitializeComponent();
        }

        private void FamilyData_Resize(object sender, EventArgs e)
        {
            lblTitle.Size =new Size(Width,(int)(0.20 * Height)); 
            panel1.Height=(int)(0.8 * Height);
        }
    }
}
