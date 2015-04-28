using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyProperty.Entity
{
    /// <summary>
    /// 招商项目
    /// </summary>
    [Table("T_Project")]
    public class Project
    {
        public int ID { get; set; }

        /// <summary>
        /// 项目名称
        /// </summary>
        public string ProjectName { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// 客户ID
        /// </summary>
        [ForeignKey("Customer")]
        public int CustomerID { get; set; }

        public virtual Customer Customer { get; set; }

        /// <summary>
        /// 增加时间
        /// </summary>
        public DateTime Time { get; set; }

        /// <summary>
        /// 开始时间
        /// </summary>
        public DateTime Begin { get; set; }

        /// <summary>
        /// 结束时间
        /// </summary>
        public DateTime End { get; set; }
    }
}
