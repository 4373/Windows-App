using System;
using System.Drawing;
using System.Windows.Forms;
using BaseMain.Common;
using BaseMain.Common.控件类;
using BaseMain.UserUI.CardSelect;
using BaseMain.UserUI.ControlMove;
using BaseMain.UserUI.DataDispalyUI;
using BaseMain.UserUI.KeyBoardInput.DataDispalyUI;

namespace BaseMain.UserUI
{
    public partial class UserUIAllOf : UserControl
    {
        //j将局部变量赋给以下,用来全局操控                    
        private readonly BloodPressure _bpPressure;
        private readonly HeightData _hdHeightData;
        private readonly WaistLine _wlWaistLine;
        private readonly WeightData _wdWeightData;
        private readonly PatientAge _paPatientAge;
        private readonly DataInput _diDataInput;
        private readonly PrevAndNext _pnPrevAndNext;

        #region 事件
        /// <summary>
        /// 点击包含下一步和上一步中的下一步事件
        /// </summary>
        public event Action PrevAndNextNext;

        /// <summary>
        /// 点击包含下一步和上一步中的上一步事件
        /// </summary>
        public event Action PrevAndNextPrev;

        /// <summary>
        /// 点击只有下一步的控件的事件
        /// </summary>
        public event Action OnlyNextClik;

        #endregion
        //获取用户填写信息
        private string _needMessage;
        public string NeedMessage
        {
            get { return _needMessage; }
            set { _needMessage = value; }
        }

        private string _titleOf;
        /// <summary>
        /// 设置或取得页面的标题
        /// </summary>
        public string TitleOf
        {
            get { return _titleOf; }
            set { _titleOf = value; }
        }

        /// <summary>
        /// 获取或设置该实例是第几页
        /// </summary>
        private int _pageNum;
        /// <summary>
        /// 获取或设置该实例是第几页
        /// </summary>
        public int PageNum
        {
            get { return _pageNum; }
            set { _pageNum = value; }
        }


        /// <summary>
        /// 页面中用户输入的类别
        /// </summary>
        public InputType InputStyle { get; set; }

        /// <summary>
        /// 页面的数据的显示类别:血压,身高,腰围,体重中的一项
        /// </summary>
        public DataShowType ShowType { get; set; }


        /// <summary>
        /// 自定义每个页面的样式
        /// </summary>
        /// <param name="title">页面的标题</param>
        /// <param name="type">是选择卡片,还是数字键</param>
        /// <param name="pageNum">页面的页数</param>
        /// <param name="dataShowType">数据:血压,身高,腰围,体重中的一项</param>
        /// <param name="cardData">要写入卡片的数据</param>
        /// <param name="moveType">上一步下一步 上一步提交 下一步</param>
        public UserUIAllOf(string title, int pageNum, InputType type, DataShowType dataShowType, CardData cardData, MoveType moveType)
        {
            InitializeComponent();

            //标题
            var title1 = new Title
            {
                title = title,
                BackColor = Color.White
            };
            panel1.Controls.Add(title1);
            title1.Dock = DockStyle.Fill;
            _titleOf = title;

            //进度条
            var progressBar1 = new ProgressBarUser(pageNum);
            panel2.Controls.Add(progressBar1);
            progressBar1.Dock = DockStyle.Fill;
            _pageNum = pageNum;
            //数据处理
            switch (type)//卡片还是数字键输入
            {
                case InputType.KeyBoard://如果是数字键的输入
                    var dataInput1 = new DataInput();
                    //数据输入事件
                    dataInput1.SetInput += dataInput1_SetInput;//输入
                    //数据清除事件
                    dataInput1.ClearInput += dataInput1_ClearInput;
                    panel3.Controls.Add(dataInput1);
                    dataInput1.Height = (int)(0.40 * panel3.Height / 0.55);
                    dataInput1.Dock = DockStyle.Bottom;
                    _diDataInput = dataInput1;
                    switch (dataShowType)//是哪种数据:血压,身高,腰围,体重中的一项
                    {
                        case DataShowType.BloodPressure: var dataShowBp = new BloodPressure();//血压
                            //
                            panel3.Controls.Add(dataShowBp);//加入panel
                            dataShowBp.Dock = DockStyle.Top;//因为该panel是放卡片  或  键盘和显示数据  ,当时后者的时候,要一分为二
                            dataShowBp.Height = (int)(0.15 * panel3.Height / 0.55);//设置占比
                            _bpPressure = dataShowBp;//将局部变量赋值给全局变量
                            break;
                        case DataShowType.HeightData: var dataShowHd = new HeightData();//身高
                            panel3.Controls.Add(dataShowHd);
                            dataShowHd.Dock = DockStyle.Top;
                            dataShowHd.Height = (int)(0.15 * panel3.Height / 0.55);
                            _hdHeightData = dataShowHd;
                            break;
                        case DataShowType.WaistLine: var dataShowWl = new WaistLine();//腰围
                            panel3.Controls.Add(dataShowWl);
                            dataShowWl.Dock = DockStyle.Top;
                            dataShowWl.Height = (int)(0.15 * panel3.Height / 0.55);
                            _wlWaistLine = dataShowWl;
                            break;
                        case DataShowType.WeightData: var dataShowWd = new WeightData();//体重
                            panel3.Controls.Add(dataShowWd);
                            dataShowWd.Dock = DockStyle.Top;
                            dataShowWd.Height = (int)(0.15 * panel3.Height / 0.55);
                            _wdWeightData = dataShowWd;
                            break;
                        case DataShowType.PatientAge: var dataShowPa = new PatientAge();
                            panel3.Controls.Add(dataShowPa);
                            dataShowPa.Dock = DockStyle.Top;
                            dataShowPa.Height = (int)(0.15 * panel3.Height / 0.55);
                            _paPatientAge = dataShowPa;
                            break;
                        default:
                            ;
                            break;
                    }
                    ShowType = dataShowType;
                    break;
                case InputType.TwoMouseSelect://如果是两卡片输入
                    var mouseTwoSelection = new TwoSelection(cardData.CardTitle, cardData.CardContent, cardData.Proportion);
                    //注册卡片点击事件
                    mouseTwoSelection.TwoSelectionClik += mouseTwoSelection_TwoSelectionClik;
                    panel3.Controls.Add(mouseTwoSelection);
                    mouseTwoSelection.Dock = DockStyle.Fill;
                    break;
                case InputType.FourMouseSelect://如果是四卡片输入
                    var mouseFourSelection = new FourSelection(cardData.CardTitle, cardData.CardContent, cardData.Proportion);
                    //注册卡片点击事件
                    mouseFourSelection.FourSelectClik += mouseFourSelection_FourSelectClik;
                    panel3.Controls.Add(mouseFourSelection);
                    mouseFourSelection.Dock = DockStyle.Fill;
                    break;
            }
            InputStyle = type;
            //向前向后样式
            switch (moveType)
            {
                case MoveType.NextAndPrev:
                    var moveNext = new PrevAndNext();
                    _pnPrevAndNext = moveNext;
                    moveNext.RightString = "下一步";
                    panel4.Controls.Add(moveNext);
                    moveNext.Dock = DockStyle.Fill;
                    //注册点击事件
                    moveNext.Next += prevAndNext1_Next;//下一步
                    moveNext.Prev += prevAndNext1_Prev;//上一步
                    break;
                case MoveType.OnlyNext:
                    var onlyNext = new OnlyNext();
                    panel4.Controls.Add(onlyNext);
                    onlyNext.Dock = DockStyle.Fill;
                    onlyNext.Next += onlyNext_Next;//下一步
                    break;
                case MoveType.PrevAndSubmit:
                    var moveSubmit = new PrevAndNext();
                    _pnPrevAndNext = moveSubmit;
                    moveSubmit.RightString = "提交";
                    panel4.Controls.Add(moveSubmit);
                    moveSubmit.Dock = DockStyle.Fill;
                    //注册点击事件
                    moveSubmit.Next += prevAndNext1_Next;//提交,和上面下一步是一个事件
                    moveSubmit.Prev += prevAndNext1_Prev;//上一步
                    break;
            }

        }

        void onlyNext_Next()
        {
            if (!string.IsNullOrEmpty(_needMessage))
            {
                if (OnlyNextClik != null) OnlyNextClik();
            }

        }


        //键盘清除键点击事件
        void dataInput1_ClearInput()
        {
            if (_bpPressure != null)
            {
                _bpPressure.SetText(string.Empty);
                _needMessage = _bpPressure.GetText();
            }

            if (_hdHeightData != null)
            {
                _hdHeightData.SetText(string.Empty);
                _needMessage = _hdHeightData.GetText();
            }

            if (_wlWaistLine != null)
            {
                _wlWaistLine.SetText(string.Empty);
                _needMessage = _wlWaistLine.GetText();
            }

            if (_wdWeightData != null)
            {
                _wdWeightData.SetText(string.Empty);
                _needMessage = _wdWeightData.GetText();
            }

            if (_paPatientAge != null)
            {
                _paPatientAge.SetText(string.Empty);
                _needMessage = _paPatientAge.GetText();
            }
        }

        //键盘数字键 点击事件
        void dataInput1_SetInput(string obj)
        {
            if (_bpPressure != null) { _bpPressure.SetText(obj); _needMessage = _bpPressure.GetText(); }
            if (_hdHeightData != null) { _hdHeightData.SetText(obj); _needMessage = _hdHeightData.GetText(); }
            if (_wlWaistLine != null) { _wlWaistLine.SetText(obj); _needMessage = _wlWaistLine.GetText(); }
            if (_wdWeightData != null) { _wdWeightData.SetText(obj); _needMessage = _wdWeightData.GetText(); }
            if (_paPatientAge != null) { _paPatientAge.SetText(obj); _needMessage = _paPatientAge.GetText(); }
        }

        //卡片选择的内容的点击事件
        void mouseFourSelection_FourSelectClik(string obj)
        {
            _needMessage = "";
            _needMessage = obj;
            //如果该页面是最后页面,那么点击卡片不能前进,只能赋值
            if (_pnPrevAndNext != null && _pnPrevAndNext.RightString == "提交") return;
            //点击卡片实现前进
            if (PrevAndNextNext != null) PrevAndNextNext();
            if (OnlyNextClik != null) OnlyNextClik();


        }

        //卡片选择的内容的点击事件,将卡片的内容赋值给属性_needMessage
        void mouseTwoSelection_TwoSelectionClik(string obj)
        {
            _needMessage = "";
            _needMessage = obj;
            //如果该页面是最后页面,那么点击卡片不能前进,只能赋值
            if (_pnPrevAndNext != null && _pnPrevAndNext.RightString == "提交") return;
            //点击卡片实现前进
            if (PrevAndNextNext != null) PrevAndNextNext();
            if (OnlyNextClik != null) OnlyNextClik();


        }

        //设置里面控件的大小
        private void SetSizeIn()
        {
            panel1.Size = new Size(Width, (int)(Height * 0.15));//标题
            panel2.Size = new Size(Width, (int)(Height * 0.15));//进度条
            panel3.Size = new Size(Width, (int)(Height * 0.58)); //数据录入区
            panel4.Size = new Size(Width, (int)(Height * 0.13));//控制区
        }

        //设置里面控件的位子
        private void SetLocationIn()
        {
            panel1.Location = new Point(0, 0);//标题
            panel2.Location = new Point(0, (int)(Height * 0.15));//进度条
            panel3.Location = new Point(0, (int)(Height * 0.301));//数据录入区

            if (_diDataInput != null) _diDataInput.Height = (int)(0.429 * panel3.Height / 0.58);
            if (_paPatientAge != null) _paPatientAge.Height = (int)(0.15 * panel3.Height / 0.58);
            if (_wdWeightData != null) _wdWeightData.Height = (int)(0.15 * panel3.Height / 0.58);
            if (_wlWaistLine != null) _wlWaistLine.Height = (int)(0.15 * panel3.Height / 0.58);
            if (_hdHeightData != null) _hdHeightData.Height = (int)(0.15 * panel3.Height / 0.58);
            if (_bpPressure != null) _bpPressure.Height = (int)(0.15 * panel3.Height / 0.58);

            panel4.Location = new Point(0, (int)(Height * 0.87));//控制区
        }
        //设置控件大小
        public void SetSize(int x, int y)
        {
            Size = new Size(x, y);
        }
        //设置控件位子
        public void SetLocation(int x, int y)
        {
            Location = new Point(x, y);
        }
        //自定义里面控件大小
        private void UserUIForDataInput_Resize(object sender, EventArgs e)
        {
            SetSizeIn();
            SetLocationIn();
        }

        //下一步按扭事件
        private void prevAndNext1_Next()
        {
            if (!string.IsNullOrEmpty(_needMessage))
            {
                if (PrevAndNextNext != null) PrevAndNextNext();
            }
        }
        //上一步按钮事件
        private void prevAndNext1_Prev()
        {
            if (PrevAndNextPrev != null) PrevAndNextPrev();
        }

    }
}
