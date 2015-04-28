using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyProperty.Entity
{
    /// <summary>
    /// 会所管理
    /// </summary>
    [Table("T_Place")]
    public class Place
    {
        public int ID { get; set; }

        /// <summary>
        /// 会所名称
        /// </summary>
        public string PlaceName { get; set; }

        /// <summary>
        /// 会所地址
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        ///   增加时间
        /// </summary>
        public DateTime Time { get; set; }
    }
}
