using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyProperty.Entity
{
    public enum EquipmentType
    { 
        基础设施,
        生活
    }

    [Table("T_Equipment")]
    public class Equipment
    {
        public int ID { get; set; }

        /// <summary>
        /// 编号
        /// </summary>
        public string Num { get; set; }

        /// <summary>
        /// 设备名称
        /// </summary>
        public string EquipmentName { get; set; }

        /// <summary>
        /// 设备名称
        /// </summary>
        public byte[] Icon { get; set; }

        /// <summary>
        /// 设备类型
        /// </summary>
        public EquipmentType Type { get; set; }

        /// <summary>
        /// 价格
        /// </summary>
        public double Price { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; }
    }
}
