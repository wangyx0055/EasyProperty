using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyProperty.Entity
{
    /// <summary>
    ///  收费
    /// </summary>
    public class Charge
    {
        public int ID { get; set; }

        /// <summary>
        /// 房产ID
        /// </summary>
        public int EstateID { set; get; }

        /// <summary>
        /// 应交钱数
        /// </summary>
        public double ShouldCharge { get; set; }

        /// <summary>
        /// 实际交钱
        /// </summary>
        public double ActualCharge { get; set; }

        /// <summary>
        /// 上月欠款
        /// </summary>
        public double LastMonthCharge { get; set; }

        /// <summary>
        /// 最迟时间
        /// </summary>
        public DateTime LatestTime { get; set; }
    }
}
