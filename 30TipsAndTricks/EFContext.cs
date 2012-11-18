using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace _30TipsAndTricks
{
    public class EFContext : DbContext
    {
        static EFContext()
        {
            Database.SetInitializer<EFContext>(null);
        }

        public EFContext()
            : base()
        {
        }

        public DbSet<Customer> Customers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}