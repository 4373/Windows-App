using System;
using System.Drawing;
using System.Windows.Forms;


namespace BaseMain.UserUI
{
    public partial class DataInput : UserControl
    {
        public  event  Action<string> SetInput;
        public event Action ClearInput;
        public string DataInputString;
        public DataInput()
        {
            InitializeComponent();
            for (int i = 1; i < 12; i++)
            {
                if (i < 11)
                {
                    Number num;
                    num = new Number(i + "");
                    if (i == 10)
                    {
                        num = null;
                        num = new Number("0");
                    }
                    num.SetText += num_GetText;
                    Controls.Add(num);
                }
                else if (i == 11)
                {
                    Number num = new Number("清除");
                    num.SetFontSize(26);
                    num.Clears += num_Clears;
                    Controls.Add(num);
                }
            }
        }
        //点击清除按键,相当于输入空字符
        void num_Clears()
        {
            if (ClearInput != null)
                ClearInput();
            DataInputString = string.Empty;
        }

        //点击键盘数字
        void num_GetText(string obj)
        {
            if (SetInput != null) SetInput(obj);
            DataInputString = obj;
        }


        //设置控件大小
        public void SetSize(int x, int y)
        {
            this.Size = new Size(x, y);
        }

        //设置控件位子
        public void SetLocation(int x, int y)
        {
            this.Location = new Point(x, y);
        }

        //初始化数字按钮
        private void DataInput_Resize(object sender, EventArgs e)
        {
            int i = 1;
            foreach (var item in Controls)
            {

                var t = item.GetType();
                if (t == typeof(Number))
                {
                    var a = item as Number;
                    if (a != null)
                    {
                        a.Size = new Size(80*Width/800, 80*Width/800);
                        if (i < 7)
                        {
                            a.Location = new Point(30*Width/800 + 130*Width/800*(i - 1),  10*Width/800);
                            i++;
                        }
                        else
                        {
                            a.Location = new Point(94 * Width / 800 + (i - 7) * 130 * Width / 800, 240 * Height / 800 + 40 * Width / 800);
                            i++;
                        }

                    }
                }
            }
        }


    }
}
