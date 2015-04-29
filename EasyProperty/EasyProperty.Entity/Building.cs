using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyProperty.Entity
{
    [Table("T_Building")]
    public class Building
    {
        public int ID { get; set; }

        [ForeignKey("Community")]
        public int CommunityID { get; set; }

        public virtual Community Community { get; set; }

        public string BuildingName { get; set; }
    }
}
