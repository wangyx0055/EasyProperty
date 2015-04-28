using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyProperty.Entity
{
    /// <summary>
    /// 损坏程度
    /// </summary>
    public enum DamageLevel
    {
        轻微,
        一般,
        重度
    }

    /// <summary>
    /// 设备维修记录
    /// </summary>
    [Table("T_EquipmentRepairRecord")]
    public class EquipmentRepairRecord
    {
        public int ID { get; set; }

        /// <summary>
        /// 设备ID
        /// </summary>
        [ForeignKey("Equipment")]
        public int EquipmentID { get; set; }


        public virtual Equipment Equipment { get; set; }

        /// <summary>
        /// 维修原因
        /// </summary>
        public string Reason { set; get; }

        public int DamageLevelAsInt { set; get; }

        [NotMapped]
        public DamageLevel DamageLevel
        {
            get { return (DamageLevel)DamageLevelAsInt; }
            set { DamageLevelAsInt = (int)value; }
        }

        /// <summary>
        /// 损坏日期
        /// </summary>
        public DateTime DamageTime { get; set; }

        /// <summary>
        /// 维修日期
        /// </summary>
        public DateTime RepairTime { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; }

    }
}
