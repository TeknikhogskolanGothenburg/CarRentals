namespace CarRentals.Models.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<CarRentals.Models.DAL.CarRentalsContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(CarRentals.Models.DAL.CarRentalsContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            //var cars = new List<Car>
            //{
            //    new Car("3434"),
            //};

            //cars.ForEach(s => context.Cars.Add(s));
            //context.SaveChanges();
        }
    }
}
