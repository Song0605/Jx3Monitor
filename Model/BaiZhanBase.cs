using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jx3BaiZhanCDMonitor.Model
{
    public class BaiZhanProp
    {
        /// <summary>
        /// 名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 精力
        /// </summary>
        public string Energy { get; set; }
        /// <summary>
        /// 耐力
        /// </summary>
        public string Power { get; set; }
        /// <summary>
        /// 本周cd
        /// </summary>
        public bool TotalWeekProgress { get; set; }
    }
}
