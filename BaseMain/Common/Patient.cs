using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseMain.Common
{
    public class Patient
    {
        /// <summary>
        /// 主键
        /// </summary>
        public int PNo { get; set; }

        /// <summary>
        /// 检查日期
        /// </summary>
        public DateTime PDateTime { get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        public string PName { get; set; }

        /// <summary>
        /// 患者条形码
        /// </summary>
        public int PBarCode { get; set; }

        /// <summary>
        /// 患者性别
        /// </summary>
        public bool PSex { get; set; }

        /// <summary>
        /// 患者年龄
        /// </summary>
        public int PAge { get; set; }

        /// <summary>
        /// 患者身高
        /// </summary>
        public int PHeight { get; set; }

        /// <summary>
        /// 患者体重
        /// </summary>
        public int Pweight { get; set; }

        /// <summary>
        /// 患者腰围
        /// </summary>
        public string PWaist { get; set; }

        /// <summary>
        /// 高血压
        /// </summary>
        public int PHighBloodPressure { get; set; }

        /// <summary>
        /// 低血压
        /// </summary>
        public int PLowBloodPressure { get; set; }


        /// <summary>
        /// 是否使用降压药
        /// </summary>
        public bool PUseHypotensor { get; set; }

        /// <summary>
        /// 血糖值
        /// </summary>
        public string PBloodSugar { get; set; }

        /// <summary>
        /// 是否吸烟
        /// </summary>
        public bool PSmoking { get; set; }

        /// <summary>
        /// 运动强度
        /// </summary>
        public bool PLackExercise { get; set; }

        /// <summary>
        /// 遗传性
        /// </summary>
        public bool PHeredity { get; set; }

        /// <summary>
        /// 高胆固醇
        /// </summary>
        public bool PHighCholesterol { get; set; }

        /// <summary>
        /// 短暂性脑缺血或中风
        /// </summary>
        public bool PStroke { get; set; }

        /// <summary>
        /// 家族中风史
        /// </summary>
        public bool PFamilyStroke { get; set; }

    }
}
