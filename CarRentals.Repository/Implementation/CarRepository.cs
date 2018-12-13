using CarRentals.Domain;
using CarRentals.Models.DAL;
using CarRentals.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;


namespace CarRentals.Repository.Implementation
{
    public class CarRepository : ICarRepository
    {
        public void CreateCar(Car car)
        {
            using(var context = new CarRentalsContext())
            {
                context.Cars.Add(car);
                context.SaveChanges();
            }
        }

        public void DeleteCar(Car car)
        {
            using(var context = new CarRentalsContext())
            {
                context.Cars.Remove(car);
                context.SaveChanges();
            }
        }

        public void DeleteCarById(int carId)
        {
            using(var context = new CarRentalsContext())
            {
                var car = context.Cars.Where(c => c.ID == carId).FirstOrDefault();
                context.Cars.Remove(car);
                context.SaveChanges();
            }
        }

        public Car GetCarById(int id)
        {
            using(var context = new CarRentalsContext())
            {
                return context.Cars.FirstOrDefault(c => c.ID == id);
            }
        }

        public Car GetCarByBrand(string brand)
        {
            using(var context = new CarRentalsContext())
            {
                return context.Cars.FirstOrDefault(c => c.Brand == brand);
            } 
        }


        public Car GetCarByRegnum(string regNo)
        {
            using(var context = new CarRentalsContext())
            {
                return context.Cars.FirstOrDefault(c => c.RegistrationNo == regNo);
            }
 
        }

        public List<Car> GetAllCars()
        {
            using(var context = new CarRentalsContext())
            {
                return context.Cars.ToList();
            }

        }

        public List<Car> GetAvalibleCars(DateTime dateFrom, DateTime dateTo)
        {
            using (var context = new CarRentalsContext())
            {
               var carIds = context.Bookings.Where(x => x.StartTime <= dateFrom && x.EndTime <= dateTo)
              .Select(x => x.CarID).Distinct().ToArray();

               var result = context.Cars.Where(x => !carIds.Contains(x.ID)).ToList();
               return result;
            }
        }
    }
}


