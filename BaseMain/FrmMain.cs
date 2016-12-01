using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using BaseMain.Common;
using BaseMain.Common.控件类;
using BaseMain.UserUI;

namespace BaseMain
{
    public partial class FrmMain : Form
    {
        private readonly UserUIAllOf _sexUi;
        private readonly UserUIAllOf _ageUi;
        private readonly UserUIAllOf _heightUi;
        private readonly UserUIAllOf _weightUi;
        private readonly UserUIAllOf _waistLineUi;
        private readonly UserUIAllOf _bloodPressureUi;
        private readonly UserUIAllOf _useMedicineUi;
        private readonly UserUIAllOf _bloodSugarUi;
        private readonly UserUIAllOf _smokingUi;
        private readonly UserUIAllOf _sportUi;
        private readonly UserUIAllOf _inheritanceUi;
        private readonly UserUIAllOf _highCholesterolUi;
        private readonly UserUIAllOf _strokeUi;
        private readonly UserUIAllOf _familyStrokeUi;
        //用来做效果--透明过度
        private ResultReport _thisrr;
        private FrmEscOrFinishGiveUp _fGiveUp;
        private FrmEscOrFinishGiveUp _fPrint;
       
        /// <summary>
        /// 传递过来的patient
        /// </summary>
        private readonly Patient _patient;

        /// <summary>
        /// 窗体的集合
        /// </summary>
        readonly List<UserUIAllOf> _frmList = new List<UserUIAllOf>();

        /// <summary>
        /// 上次panel的x坐标值
        /// </summary>
        private int _lastPanelLocationX;
        /// <summary>
        /// 第几个页面
        /// </summary>
        private int _park = 1;

        /// <summary>
        /// 二次函数从1开始增
        /// </summary>
        private int _step = 1;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="p">从条形码中扫描的带有姓名和条形码号的患者对象</param>
        public FrmMain(Patient p)
        {
            InitializeComponent();
            UserGiveUp userGiveUp = new UserGiveUp();

            userGiveUp.GiveUpClik += _userGiveUp_GiveUpClik;
            panel2.Controls.Add(userGiveUp);


            _patient = p;

            //实例化每个页面

            #region 1 性别
            UserUIAllOf sexUi = new UserUIAllOf(
                "性别",
                1,
                InputType.TwoMouseSelect,
                DataShowType.Nothing,
                new CardData()
                {
                    CardTitle = new[] { "男", "女" },
                    CardContent = new[] { "", "" },
                    Proportion = new[] { 1.0f, 1.0f }
                },
                MoveType.OnlyNext
                );
            sexUi.OnlyNextClik += sexUI_OnlyNextClik;
            panel1.Controls.Add(sexUi);
            _frmList.Add(sexUi);
            _sexUi = sexUi;
            #endregion

            #region 2 年龄
            UserUIAllOf ageUi = new UserUIAllOf(
                "年龄", 2,
                InputType.KeyBoard,
                DataShowType.PatientAge,
                new CardData(),
                MoveType.NextAndPrev
                );
            ageUi.PrevAndNextNext += PrevOrNext_Next;
            ageUi.PrevAndNextPrev += PrevAndNextPrev;
            panel1.Controls.Add(ageUi);
            _frmList.Add(ageUi);
            _ageUi = ageUi;
            #endregion

            #region 3 身高
            UserUIAllOf heightUi = new UserUIAllOf(
                "身高",
                3,
                InputType.KeyBoard,
                DataShowType.HeightData,
                new CardData(),
                MoveType.NextAndPrev
                );
            heightUi.PrevAndNextNext += PrevOrNext_Next;
            heightUi.PrevAndNextPrev += PrevAndNextPrev;
            panel1.Controls.Add(heightUi);
            _frmList.Add(heightUi);
            _heightUi = heightUi;
            #endregion

            #region 4 体重
            UserUIAllOf weightUi = new UserUIAllOf(
                "体重", 4,
                InputType.KeyBoard,
                DataShowType.WeightData,
                new CardData(),
                MoveType.NextAndPrev
                );
            weightUi.PrevAndNextNext += PrevOrNext_Next;
            weightUi.PrevAndNextPrev += PrevAndNextPrev;
            panel1.Controls.Add(weightUi);
            _frmList.Add(weightUi);
            _weightUi = weightUi;
            #endregion

            #region 5 腰围
            UserUIAllOf waistLineUi = new UserUIAllOf(
                "腰围", 5,
                InputType.KeyBoard,
                DataShowType.WaistLine,
                new CardData(),
                MoveType.NextAndPrev
                );
            waistLineUi.PrevAndNextNext += PrevOrNext_Next;
            waistLineUi.PrevAndNextPrev += PrevAndNextPrev;
            panel1.Controls.Add(waistLineUi);
            _frmList.Add(waistLineUi);
            _waistLineUi = waistLineUi;
            #endregion

            #region 6 血压值
            UserUIAllOf bloodPressureUi = new UserUIAllOf(
                "血压值", 6,
                InputType.KeyBoard,
                DataShowType.BloodPressure,
                new CardData(),
                MoveType.NextAndPrev
                );
            bloodPressureUi.PrevAndNextNext += PrevOrNext_Next;
            bloodPressureUi.PrevAndNextPrev += PrevAndNextPrev;
            panel1.Controls.Add(bloodPressureUi);
            _frmList.Add(bloodPressureUi);
            _bloodPressureUi = bloodPressureUi;
            #endregion

            #region 7 降压药使用情况
            UserUIAllOf useMedicineUi = new UserUIAllOf(
                "降压药使用情况", 7,
                InputType.TwoMouseSelect,
                DataShowType.Nothing,
                new CardData()
                {
                    CardTitle = new[] { "已用降压药", "未用降压药" },
                    CardContent = new[] { "", "" },
                    Proportion = new[] { 1.0f, 1.0f }
                },
                MoveType.NextAndPrev
                );
            useMedicineUi.PrevAndNextNext += PrevOrNext_Next;
            useMedicineUi.PrevAndNextPrev += PrevAndNextPrev;
            panel1.Controls.Add(useMedicineUi);
            _frmList.Add(useMedicineUi);
            _useMedicineUi = useMedicineUi;
            #endregion

            #region 8 血糖值
            UserUIAllOf bloodSugarUi = new UserUIAllOf(
                "血糖值", 8,
                InputType.FourMouseSelect,
                DataShowType.Nothing,
                new CardData()
                {
                    CardTitle = new[] { "血糖正常", "糖尿病前期", "糖尿病", "不知道" },
                    CardContent = new[] { "", "空腹血糖\t6.1~<7.0mmol/L\n或餐后血糖\t7.8~<11.1mmol/L", "空腹血糖\t>=mmol/L\n或餐后血糖\t>=11.1mmol/L", "" },
                    Proportion = new[] { 1.0f, 0.5f, 0.5f, 1.0f }
                },
                MoveType.NextAndPrev
                );
            bloodSugarUi.PrevAndNextNext += PrevOrNext_Next;
            bloodSugarUi.PrevAndNextPrev += PrevAndNextPrev;
            panel1.Controls.Add(bloodSugarUi);
            _frmList.Add(bloodSugarUi);
            _bloodSugarUi = bloodSugarUi;
            #endregion

            #region 9 是否吸烟
            UserUIAllOf smokingUi = new UserUIAllOf(
                "是否吸烟", 9,
                InputType.TwoMouseSelect,
                DataShowType.Nothing,
                new CardData()
                {
                    CardTitle = new[] { "吸烟", "不吸烟" },
                    CardContent = new[] { "", "" },
                    Proportion = new[] { 1.0f, 1.0f }
                },
                MoveType.NextAndPrev
                );
            smokingUi.PrevAndNextNext += PrevOrNext_Next;
            smokingUi.PrevAndNextPrev += PrevAndNextPrev;
            panel1.Controls.Add(smokingUi);
            _frmList.Add(smokingUi);
            _smokingUi = smokingUi;
            #endregion

            #region 10 运动情况
            UserUIAllOf sportUi = new UserUIAllOf(
                "运动情况", 10,
                InputType.TwoMouseSelect,
                DataShowType.Nothing,
                new CardData()
                {
                    CardTitle = new[] { "缺乏运动", "不缺乏运动" },
                    CardContent = new[] { "缺乏运动参考值:\n1 运动强度<4-5次/周,持续20-30分钟/次\n2 运动强度<3次/周,持续时间40-60分钟/次", "" },
                    Proportion = new[] { 0.5f, 1.0f }
                },
                MoveType.NextAndPrev
                );
            sportUi.PrevAndNextNext += PrevOrNext_Next;
            sportUi.PrevAndNextPrev += PrevAndNextPrev;
            panel1.Controls.Add(sportUi);
            _frmList.Add(sportUi);
            _sportUi = sportUi;
            #endregion

            #region 11 一级亲属患有糖尿病情况
            UserUIAllOf inheritanceUi = new UserUIAllOf(
                "一级亲属患有糖尿病情况", 11,
                InputType.TwoMouseSelect,
                DataShowType.Nothing,
                new CardData()
                {
                    CardTitle = new[] { "一级亲属中\n有糖尿病患者", "一级亲属中\n无糖尿病患者" },
                    CardContent = new[] { "父母,兄弟姐妹,子女", "" },
                    Proportion = new[] { 0.8f, 1.0f }
                },
                MoveType.NextAndPrev
                );
            inheritanceUi.PrevAndNextNext += PrevOrNext_Next;
            inheritanceUi.PrevAndNextPrev += PrevAndNextPrev;
            panel1.Controls.Add(inheritanceUi);
            _frmList.Add(inheritanceUi);
            _inheritanceUi = inheritanceUi;
            #endregion

            #region 12 高胆固醇
            UserUIAllOf highCholesterolUi = new UserUIAllOf(
                "高胆固醇", 12,
                InputType.TwoMouseSelect,
                DataShowType.Nothing,
                new CardData()
                {
                    CardTitle = new[] { "高胆固醇", "正常" },
                    CardContent = new[] { "高胆固醇参考值:\n1 总胆固醇<6.22mmol/L\n2 低密度蛋白胆固醇<4.14mmol/L", "" },
                    Proportion = new[] { 0.5f, 1.0f }
                },
                MoveType.NextAndPrev
                );
            highCholesterolUi.PrevAndNextNext += PrevOrNext_Next;
            highCholesterolUi.PrevAndNextPrev += PrevAndNextPrev;
            panel1.Controls.Add(highCholesterolUi);
            _frmList.Add(highCholesterolUi);
            _highCholesterolUi = highCholesterolUi;
            #endregion

            #region 13 短暂性脑缺血发作或中风
            UserUIAllOf strokeUi = new UserUIAllOf(
                "短暂性脑缺血发作或中风", 13,
                InputType.TwoMouseSelect,
                DataShowType.Nothing,
                new CardData()
                {
                    CardTitle = new[] { "有过\n短暂性脑缺血发作或中风", "没有\n短暂性脑缺血发作或中风" },
                    CardContent = new[] { "", "" },
                    Proportion = new[] { 1.0f, 1.0f }
                }, MoveType.NextAndPrev
                );
            strokeUi.PrevAndNextNext += PrevOrNext_Next;
            strokeUi.PrevAndNextPrev += PrevAndNextPrev;
            panel1.Controls.Add(strokeUi);
            _frmList.Add(strokeUi);
            _strokeUi = strokeUi;
            #endregion

            #region 14 中风家族史
            UserUIAllOf familyStrokeUi = new UserUIAllOf(
                "中风家族史", 14,
                InputType.TwoMouseSelect,
                DataShowType.Nothing,
                new CardData()
                {
                    CardTitle = new[] { "有中风家族史", "没有中风家族史" },
                    CardContent = new[] { "", "" },
                    Proportion = new[] { 1.0f, 1.0f }
                }, MoveType.PrevAndSubmit
                );
            familyStrokeUi.PrevAndNextNext += PrevOrNext_Next;
            familyStrokeUi.PrevAndNextPrev += PrevAndNextPrev;
            panel1.Controls.Add(familyStrokeUi);
            _frmList.Add(familyStrokeUi);
            _familyStrokeUi = familyStrokeUi;

            #endregion

            //panel1.Size = new Size(_frmList.Count * Width, Height);
            //初始化调查页面大小

        }

        /// <summary>
        /// 点击"放弃填写"事件
        /// </summary>
        void _userGiveUp_GiveUpClik()
        {

            FrmEscOrFinishGiveUp esc = new FrmEscOrFinishGiveUp("确认放弃本次筛查报告填写吗", "*本次已填写的内容将不会被保存");
            esc.Opacity = 0.0;
            _fGiveUp = esc;
            esc.Show();
            timerGiveUp.Start();

        }



        void sexUI_OnlyNextClik()
        {
            timerNext.Start();
        }

        void PrevAndNextPrev()
        {
            timerPre.Start();
        }

        void PrevOrNext_Next()
        {

            if (_park != _frmList.Count)
            {
                timerNext.Start();
            }
            else
            {
                FrmEscOrFinishGiveUp finish = new FrmEscOrFinishGiveUp("确认提交筛查报告吗?", "*提交后本次结果将不可被修改");
                finish.Opacity = 0.0;
                _fPrint = finish;
                timerPrint.Start();
                finish.ShowDialog();//询问是否提交报告界面
                if (finish.DialogResult == DialogResult.OK)
                {
                    _patient.PSex = _sexUi.NeedMessage == "男";//男true女false
                    _patient.PAge = Convert.ToInt32(_ageUi.NeedMessage);
                    _patient.PHeight = Convert.ToInt32(_heightUi.NeedMessage);
                    _patient.Pweight = Convert.ToInt32(_weightUi.NeedMessage);
                    _patient.PWaist = _waistLineUi.NeedMessage;
                    _patient.PHighBloodPressure = Convert.ToInt32(_bloodPressureUi.NeedMessage.Split('@')[0]);
                    _patient.PLowBloodPressure = Convert.ToInt32(_bloodPressureUi.NeedMessage.Split('@')[1]);
                    _patient.PUseHypotensor = _useMedicineUi.NeedMessage == "已用降压药";//已使用为true
                    _patient.PBloodSugar = _bloodSugarUi.NeedMessage.Split('@')[0];
                    _patient.PSmoking = _smokingUi.NeedMessage == "吸烟";//吸烟为true
                    _patient.PLackExercise = _sportUi.NeedMessage.Split('@')[0] == "缺乏运动";//缺乏运动 为true
                    _patient.PHeredity = _inheritanceUi.NeedMessage.Split('@')[0] == "一级亲属中\n有糖尿病患者";//亲属有病为true
                    _patient.PHighCholesterol = _highCholesterolUi.NeedMessage.Split('@')[0] == "高胆固醇";//高胆固醇为true
                    _patient.PStroke = _strokeUi.NeedMessage.Split('@')[0] == "有过\n短暂性脑缺血发作或中风"; //有为true
                    _patient.PFamilyStroke = _familyStrokeUi.NeedMessage.Split('@')[0] == "有中风家族史";
                    _patient.PDateTime = DateTime.Now;
                    ResultReport rr = new ResultReport(_patient);
                    rr.Opacity = 0.0;
                    _thisrr = rr;
                    rr.Show();//结果报告界面
                    timerAskToReport.Start();
                }
                else
                {
                    finish.Close();
                }
            }
        }
        //窗体大小改变时
        private void FrmMain_Resize(object sender, EventArgs e)
        {
            panel2.Location = new Point(Width / 80, Width / 80);
            panel1.Size = new Size(Width * _frmList.Count, Height);
            panel1.Location = new Point(-(_park - 1) * Width, 0);

        }

        //panel大小改变时.里面的每个调查页面跟着改变
        private void panel1_Resize(object sender, EventArgs e)
        {

            foreach (var item in _frmList)
            {
                item.SetSize(Width, Height);
                item.SetLocation((item.PageNum - 1) * Width, 0);

            }
        }

        //点击下一步的timer 事件
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (_park == _frmList.Count)
            {
                timerNext.Stop();
                return;
            }

            int w = 3 * _step * _step;
            panel1.Location = new Point(_lastPanelLocationX - w, 0);

            _step++;
            var cc = Math.Sqrt(Width / 3);
            if (_step >= cc)
            {
                timerNext.Stop();
                _step = 1;
                _park++;

                panel1.Location = new Point(-Width * (_park - 1), 0);
                _lastPanelLocationX = panel1.Location.X;
            }

        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (_park == 1)
            {
                timerPre.Stop();
                return;
            }
            int w = 3 * _step * _step;
            panel1.Location = new Point(_lastPanelLocationX + w, 0);

            _step++;
            // ReSharper disable once PossibleLossOfFraction
            var cc = Math.Sqrt(Width / 3);
            if (_step >= cc)
            {
                timerPre.Stop();
                _step = 1;
                _park--;
                panel1.Location = new Point(-Width * (_park - 1), 0);
                _lastPanelLocationX = panel1.Location.X;
            }
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            var a = _park;
            panel1.Location = new Point(0, 0);
        }

        private void timer3_Tick(object sender, EventArgs e)
        {

            _thisrr.Opacity += 0.2;
            if (_thisrr.Opacity == 1.0)
            {
                this.Close();
                timerAskToReport.Stop();

            }
        }

        private void timerGiveUp_Tick(object sender, EventArgs e)
        {
            _fGiveUp.Opacity += 0.2;
            if (_fGiveUp.Opacity==1.0)
            {
                timerGiveUp.Stop();
                _fGiveUp.ClicYseOrNo += _fGiveUp_ClicYseOrNo;

            }
        }

        void _fGiveUp_ClicYseOrNo()
        {
            if (_fGiveUp.YesOrNo=="OK")
            {
                _fGiveUp.Close();
                this.Close();
            }
            else
            {
                _fGiveUp.Close();
            }
        }

        //是否提交报告的timer
        private void timerFinish_Tick(object sender, EventArgs e)
        {
            _fPrint.Opacity += 0.2;
            if (_fPrint.Opacity == 1.0)
            {
                timerPrint.Stop();
            }
        }

    }
}
