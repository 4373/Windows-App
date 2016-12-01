using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseMain.Common.控件类
{
    public class CardData
    {
        /// <summary>
        /// 卡片标题
        /// </summary>
        private string[] _cardTitle;

        /// <summary>
        /// 卡片标题
        /// </summary>
        public string[] CardTitle
        {
            get { return _cardTitle; }
            set { _cardTitle = value; }
        }

        /// <summary>
        /// 卡片内容
        /// </summary>
        private string[] _cardContent;
        public string[] CardContent
        {
            get { return _cardContent; }
            set { _cardContent = value; }
        }

        /// <summary>
        /// 卡片标题占高比
        /// </summary>
        private float[] _proportion;
        public float[] Proportion
        {
            get { return _proportion; }
            set { _proportion = value; }
        }



    }
}
