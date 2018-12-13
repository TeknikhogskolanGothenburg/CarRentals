using CarRentals.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace CarRentals.Models.DAL
{
    public class CarRentalsContext : DbContext
    {

     
        public CarRentalsContext() : base(ConfigurationManager.ConnectionStrings["CarRentalsContext"].ConnectionString)
        {

        }

        public DbSet<Car> Cars { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Customer> Customers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

    }
}
