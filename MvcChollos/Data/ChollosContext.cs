using MvcChollos.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MvcChollos.Data
{
    public class ChollosContext : DbContext
    {
        public DbSet<Chollo> Chollos { get; set; }

        public ChollosContext() : base("name=cadenachollos")
        {

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<ChollosContext>(null);
        }
    }
}