using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EasyProperty.WebApp.Models
{
    public class DB:DbContext
    {
        public DB():base(""){}
    }
}