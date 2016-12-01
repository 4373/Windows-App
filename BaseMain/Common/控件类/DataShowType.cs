using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseMain.Common.控件类
{
    /// <summary>
    /// 显示何种数据
    /// </summary>
    public enum DataShowType
    {
        /// <summary>
        /// 血压
        /// </summary>
        BloodPressure,
        /// <summary>
        /// 身高
        /// </summary>
        HeightData,
        /// <summary>
        /// 腰围
        /// </summary>
        WaistLine,
        /// <summary>
        /// 体重
        /// </summary>
        WeightData,
        /// <summary>
        /// 年龄
        /// </summary>
        PatientAge,
        /// <summary>
        /// 没有该项
        /// </summary>
        Nothing
    }
}
