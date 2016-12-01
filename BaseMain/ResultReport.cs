using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using BaseMain.Common;

namespace BaseMain
{
    public partial class ResultReport : Form
    {
        private FrmEscOrFinishGiveUp _fGiveUpPrint;
        public ResultReport(Patient patient )
        {
            InitializeComponent();
            baseInfo1.BaseId = patient.PNo.ToString();
            baseInfo1.BaseName = patient.PName;
            baseInfo1.BaseSex = patient.PSex  ? "男" : "女";
            baseInfo1.BaseAge = patient.PAge+"周岁";
            baseInfo1.BaseHeight = patient.PHeight+"厘米";
            baseInfo1.BaseWaist = patient.PWaist;
            baseInfo1.BaseTime = patient.PDateTime.ToString(CultureInfo.InvariantCulture);
            baseInfo1.BaseWeight = patient.Pweight+"公斤";

            lifeStyle1.Smoking = patient.PSmoking;
            lifeStyle1.Sport = patient.PLackExercise;

            healthStation1.BSugarHeredity = patient.PHeredity;
            healthStation1.BloodPressure = patient.PHighBloodPressure + "/" + patient.PLowBloodPressure + "mmHg";
            healthStation1.BloodSugar = patient.PBloodSugar;
            healthStation1.FamilyStroke = patient.PFamilyStroke;
            healthStation1.HighCholesterol = patient.PHighCholesterol;
            healthStation1.UseHypotensor = patient.PUseHypotensor;
            printDataOrNot1.NotPrintEvent += printDataOrNot1_NotPrintEvent;
            printDataOrNot1.PrintEvent += printDataOrNot1_PrintEvent;
        }

        //点击打印报告执行的方法
        void printDataOrNot1_PrintEvent()
        {
            this.Close();
        }

        void printDataOrNot1_NotPrintEvent()
        {
            FrmEscOrFinishGiveUp giveUp = new FrmEscOrFinishGiveUp("确认放弃报告打印吗?", "＊您可在待机画面下选择重新打印报告");
            _fGiveUpPrint = giveUp;
            _fGiveUpPrint.Opacity = 0.0;
            timerGiveUpPrint.Start();
            giveUp.ShowDialog();//询问界面
            if (giveUp.DialogResult == DialogResult.OK)//确认放弃报告打印
            {
                giveUp.Dispose();//询问界面关闭
                Close();
                Dispose();

            }
            else if (giveUp.DialogResult == DialogResult.Cancel)//不放弃
            {
                giveUp.Dispose();//询问界面
            }
        }
        
        


        private bool _isNotOnPanel;
        private void ResultReport_Resize(object sender, EventArgs e)
        {
            lblTitle.Height = (int)(Height * 0.15);
            printDataOrNot1.Height = (int)(Height * 0.13);

            panel.Size = new Size(Width, (int)(Height * 0.72));
            panel.Location = new Point(0, (int)(Height * 0.15));

            panel1.Size=new Size(Width,(int)(34*panel.Height/10));
            baseInfo1.Size = new Size(panel1.Width, 8 * panel.Height / 10);
            baseInfo1.Location = new Point(0, 0);
            lifeStyle1.Size = new Size(panel1.Width, 8 * panel.Height / 10);
            lifeStyle1.Location = new Point(0, 8 * panel.Height / 10);
            healthStation1.Size = new Size(panel1.Width, 10 * panel.Height / 10);
            healthStation1.Location = new Point(0, baseInfo1.Height + lifeStyle1.Height);
            familyData1.Size = new Size(panel1.Width, 8 * panel.Height / 10);
            familyData1.Location = new Point(0, baseInfo1.Height + lifeStyle1.Height + healthStation1.Height);

        }

        /// <summary>
        /// 滑轮滚动翻页
        /// </summary>
        /// <param name="e"></param>
        protected override void OnMouseWheel(MouseEventArgs e)
        {
            if (!_isNotOnPanel)
            {
                var a = e.Delta;//往外是正 往里是负  
                var y = panel1.Location.Y;
                if (e.Delta < 0&&y>(panel.Height-panel1.Height))//往里
                {
                    var b =y +a;
                    panel1.Location=new Point(0,b);

                }
                if (e.Delta > 0&&y!=0)//往外
                {
                    var b = y + a;
                    panel1.Location = new Point(0, b);
                }
            }

        }

        private void lblTitle_MouseEnter(object sender, EventArgs e)
        {
            _isNotOnPanel = true;
        }


        private void lblTitle_MouseLeave(object sender, EventArgs e)
        {
            _isNotOnPanel = false;
        }

        private void timerGiveUpPrint_Tick(object sender, EventArgs e)
        {
            _fGiveUpPrint.Opacity += 0.2;
            if (_fGiveUpPrint.Opacity>1.0)
            {
                timerGiveUpPrint.Stop();
            }
        }








    }
}
