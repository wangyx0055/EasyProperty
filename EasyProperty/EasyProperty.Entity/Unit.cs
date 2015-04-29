using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyProperty.Entity
{
    [Table("T_Unit")]
    public class Unit
    {
        public int ID { get; set; }

        [ForeignKey("Building")]
        public int BuildingID { get; set; }

        public virtual Building  Building { get; set; }

        public string UnitName { get; set; }
    }
}
