using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebApplication2.Models;


namespace WebApplication2.Dal
{
    public class ProductContext : DbContext
    {

        public ProductContext():base()
        {
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Product>().ToTable("Maheen");
        }
        public DbSet<Product> Products { get; set; }

    }
}