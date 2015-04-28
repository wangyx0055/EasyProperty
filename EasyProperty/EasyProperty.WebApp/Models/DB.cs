using EasyProperty.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EasyProperty.WebApp.Models
{
    public class DB:DbContext
    {
        public DB() : base("mssqldb") { }

        public DbSet<User> Users { get; set; }

        public DbSet<Charge> Charges { get; set; }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<Equipment> Equipments { get; set; }

        public DbSet<EquipmentRepairRecord> EquipmentRepairRecords { get; set; }

        public DbSet<Estate> Estates { get; set; }

        public DbSet<HouseRepairApply> HouseRepairApplies { get; set; }

        public DbSet<Material> Materials { get; set; }

        public DbSet<Place> Places { get; set; }

        public DbSet<Project> Projects { get; set; }

        public DbSet<Proprietor> Proprietors { get; set; }

        public DbSet<Resident> Residents { get; set; }

    }
}