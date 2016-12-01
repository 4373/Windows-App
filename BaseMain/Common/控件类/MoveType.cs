using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseMain.Common.控件类
{
    //移动页面的样式
   public  enum MoveType
    {
       /// <summary>
       /// 只有下一步
       /// </summary>
       OnlyNext,
       /// <summary>
       /// 上一步和下一步
       /// </summary>
       NextAndPrev,
       /// <summary>
       /// 上一步和提交
       /// </summary>
       PrevAndSubmit
    }
}
