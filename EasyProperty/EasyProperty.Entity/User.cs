using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyProperty.Entity
{
    public enum UserRole
    { 
        一般管理员,
        超级管理员
    }

    [Table("T_User")]
    public class User
    {
        public int ID { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public string RealName { get; set; }

        public int UserRoleAsInt { get; set; }

        [NotMapped]
        public UserRole Role 
        {
            get { return (UserRole)UserRoleAsInt; }

            set { UserRoleAsInt = (int)value; }
        }

        public string Remark { get; set; }

    }
}
