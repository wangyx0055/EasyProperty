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
        ///  户主地址
        /// </summary>
        public string HouseHolderAddress { get; set; }


        /// <summary>
        /// 户主名
        /// </summary>
        public string HouseHolderName { get; set; }

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

    }
}
