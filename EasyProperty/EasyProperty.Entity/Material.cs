using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyProperty.Entity
{

    public enum MaterialType
    { 
       办公用品,
       工程水电,
       清洁绿化,
       劳保类,
       固定资产
    }

    /// <summary>
    /// 物料
    /// </summary>
    [Table("T_Material")]
    public class Material
    {
        public int ID { get; set; }

        /// <summary>
        /// 物资类型
        /// </summary>
        public string MaterialName { get; set; }

        /// <summary>
        /// 类型
        /// </summary>
        public int MaterialTypeAsInt { get; set; }

        [NotMapped]
        public MaterialType MaterialType 
        {
            get { return (MaterialType)MaterialTypeAsInt; }
            set { MaterialTypeAsInt = (int)value; }
        }

        /// <summary>
        /// 单价
        /// </summary>
        public double UnitPrice { get; set; }

        /// <summary>
        /// 数量
        /// </summary>
        public int Count { get; set; }

        /// <summary>
        /// 时间
        /// </summary>
        public DateTime Time { get; set; }

        /// <summary>
        ///  操作员id
        /// </summary>
        public int UserID { get; set; }
    }
}
