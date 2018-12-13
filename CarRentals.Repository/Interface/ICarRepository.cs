using CarRentals.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentals.Repository.Interface
{
    public interface ICarRepository
    {
        void CreateCar(Car car); 
        void DeleteCar(Car car);
        void DeleteCarById(int carId);
        Car GetCarById(int id);
        Car GetCarByRegnum(string regNo);
        Car GetCarByBrand(string brand);
        List<Car> GetAllCars();
        List<Car> GetAvalibleCars(DateTime dateFrom, DateTime dateTo);



    }
}


