using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Tourist.Models;

namespace Tourist.Dal
{
    public class TouristPlaceContext:DbContext
    {
        public  TouristPlaceContext()
        {

        }

        public object TouristPlaces { get; internal set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TouristPlace>().ToTable("TouristPlace");
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<TouristPlace> Tourists { get;  set; }
    }
}