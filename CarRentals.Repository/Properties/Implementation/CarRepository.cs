using CarRentals.Domain;
using CarRentals.Models.DAL;
using CarRentals.Service.Interface;
using System.Linq;


namespace CarRentals.Service.Implementation
{
    public class CarRepository : ICarRepository
    {
        public void CreateCar(Car car)
        {
            var context = new CarRentalsContext();
            context.Cars.Add(car);
            context.SaveChanges();
        }

        public void DeleteCar(Car car)
        {
            var context = new CarRentalsContext();
            context.Cars.Remove(car);
            context.SaveChanges();

        }

        public void DeleteCarById(int carId)
        {
            var context = new CarRentalsContext();
            var car = context.Cars.Where(c => c.ID == carId).FirstOrDefault();
            context.Cars.Remove(car);
            context.SaveChanges();

        }

        public Car GetCarById(int id)
        {
            var context = new CarRentalsContext();
            return context.Cars.FirstOrDefault(c => c.ID == id);

        }

        public Car GetCarByBrand(string brand)
        {
            var context = new CarRentalsContext();
            return context.Cars.FirstOrDefault(c => c.Brand == brand);
        }

        public Car GetCarByRegnum(string regNo)
        {
            var context = new CarRentalsContext();
            return context.Cars.FirstOrDefault(c => c.RegistrationNo == regNo);
        }

    }
}
