using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyProperty.Entity
{
    /// <summary>
    /// 房屋维修申请
    /// </summary>
    [Table("T_HouseRepairApply")]
    public class HouseRepairApply
    {
        public int ID { get; set; }

        /// <summary>
        /// 申请人ID
        /// </summary>
        [ForeignKey("Proprietor")]
        public int ApplicantID { set; get; }

        public virtual Proprietor Proprietor { set; get; }

        /// <summary>
        /// 房屋ID
        /// </summary>
        [ForeignKey("Estate")]
        public int EstateID { set; get; }

        public virtual Estate Estate { get; set; }

        public string Reason { get; set; }

        /// <summary>
        /// 是否受理
        /// </summary>
        public bool IsAccent { get; set; }

        /// <summary>
        /// 申请时间
        /// </summary>
        public DateTime Time { get; set; }

        /// <summary>
        /// 意见
        /// </summary>
        public string Opinion { set; get; }

        /// <summary>
        /// 处理结果
        /// </summary>
        public string Result { get; set; }

        /// <summary>
        /// 处理时间
        /// </summary>
        public DateTime DealTime { get; set; }
    }
}
