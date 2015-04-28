using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyProperty.Entity
{
    /// <summary>
    /// 客户表
    /// </summary>
    [Table("T_Customer")]
    public class Customer
    {
        public int ID { get; set; }

        public string CustomerName { get; set; }

        public string Phone { get; set; }

        public string Address { set; get; }

        public string Business { set; get; }
    }
}
