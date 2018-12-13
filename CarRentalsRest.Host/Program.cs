using CarRentals.Services.Implementation;
using System;
using System.ServiceModel.Web;

namespace CarRentalsRest.Host
{
    class Program
    {
        static void Main()
        {
            using (var hostRestService = new WebServiceHost(typeof(CustomerRestService)))
            {

                hostRestService.Open();
                Console.WriteLine("Service is running");
                Console.ReadLine();
                hostRestService.Close();
            }
        }
    }
}

