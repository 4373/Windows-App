using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseMain.Common.控件类
{
    class NumberButton
    {
        //默认未点击的颜色
        public Brush NormaBrush = new System.Drawing.SolidBrush(Color.White);
        //点击后的颜色
        public Brush MouseDownBrush = new SolidBrush(Color.DodgerBlue);
        //圆按钮的直径
        public int Length { get; set; }
        //记录是否已经点击
        public bool IsMouseDown { get; set; }

        //要显示的数字
        public string InputValue { get; set; }

        public NumberButton(string value)
        {
            InputValue = value;
        }
        //重绘
        public void Paint(Graphics g)
        {
            //绘圆
            g.CompositingQuality = CompositingQuality.HighQuality;
            g.DrawEllipse(new Pen(Color.Empty), 0, 0, Length, Length);
            //绘制字符串点击后变化

            if (IsMouseDown)
            {
                g.FillEllipse(MouseDownBrush, 0, 0, Length, Length);
            }
            else
            {
                g.FillEllipse(NormaBrush, new Rectangle(0, 0, Length, Length));
            }
        }

    }
}
