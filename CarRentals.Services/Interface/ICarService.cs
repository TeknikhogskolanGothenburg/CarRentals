using CarRentals.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace CarRentals.Services
{
    
    [ServiceContract]
    public interface ICarService
    {
        [OperationContract]
        void AddCar(Car car);

        [OperationContract]
        Car GetCarById(int id);

        [OperationContract]
        void DeleteCar(Car car);

        [OperationContract]
        void DeleteCarById(int id);

        [OperationContract]
        List<Car> GetAllCars();

        [OperationContract]
        List<Car> GetAvalibleCars(DateTime dateFrom, DateTime dateTo);

    }
}
