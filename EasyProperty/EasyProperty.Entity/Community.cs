﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyProperty.Entity
{
    [Table("T_Community")]
    public class Community
    {
        public int ID { get; set; }

        public string CommunityName { get; set; }

        public string Address { get; set; }
    }
}
