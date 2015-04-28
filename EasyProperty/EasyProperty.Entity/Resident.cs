using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyProperty.Entity
{

    /// <summary>
    /// 住户
    /// </summary>
    [Table("T_Resident")]
    public class Resident
    {
        public int ID { get; set; }

        /// <summary>
        /// 住户姓名
        /// </summary>
        public string  UserName { get; set; }

        /// <summary>
        /// 房子ID
        /// </summary>
        [ForeignKey("Eastate")]
        public int EstateID { get; set; }

        public virtual Estate Eastate { set; get; }

        /// <summary>
        /// 电话
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// 物业地址
        /// </summary>
        public string PropertyAddress { get; set; }

        /// <summary>
        /// 身份证
        /// </summary>
        public string IDCard { get; set; }

        /// <summary>
        /// 入住时间
        /// </summary>
        public DateTime CheckInTime { get; set; }

        
        /// <summary>
        /// 是否是业主
        /// </summary>
        public bool IsProprietor { get; set; }


        /// <summary>
        ///  如果是业主 对应的业主ID
        /// </summary>
        public int? ProprietorID { get; set; }

       
    }
}
