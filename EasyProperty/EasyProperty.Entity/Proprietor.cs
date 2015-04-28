using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyProperty.Entity
{
    /// <summary>
    /// 业主
    /// </summary>
    [Table("T_Proprietor")]
    public class Proprietor
    {
        public int ID { get; set; }

        /// <summary>
        /// 业主姓名
        /// </summary>
        public string Username { get; set; }

        /// <summary>
        /// 业主地址
        /// </summary>
        public string Address { set; get; }

        /// <summary>
        /// 身份证
        /// </summary>
        public string IDCard { get; set; }

        /// <summary>
        ///  电话
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// 业主名下的房产
        /// </summary>
        public virtual  ICollection<Estate> Estates { get; set; }
    }
}
