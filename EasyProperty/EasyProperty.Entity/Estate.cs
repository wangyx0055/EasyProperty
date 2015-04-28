using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyProperty.Entity
{
    /// <summary>
    /// 房产
    /// </summary>
    [Table("T_Estate")]
    public class Estate
    {
        public int ID { get; set; }

        /// <summary>
        /// 业主ID
        /// </summary>
        [ForeignKey("Proprietor")]
        public int? ProprietorID { get; set; }

        public virtual Proprietor Proprietor { get; set; }

        /// <summary>
        ///  土地号
        /// </summary>
        public string LandNum { get; set; }

        /// <summary>
        /// 产权号
        /// </summary>
        public string  PropertyNum { get; set; }

        /// <summary>
        /// 户型
        /// </summary>
        public string HouseType { get; set; }

        /// <summary>
        ///  建筑面积
        /// </summary>
        public double BuildingArea { get; set; }

        /// <summary>
        /// 建筑结构
        /// </summary>
        public string BuildingStructure { get; set; }

        /// <summary>
        /// 是否出售
        /// </summary>
        public bool IsSelled { get; set; }

        /// <summary>
        /// 出售信息
        /// </summary>
        public string SellInfo { get; set; }


        /// <summary>
        /// 添加房产时间
        /// </summary>
        public DateTime Time { get; set; }

    }
}
