using CarRentals.Domain;
using System.ServiceModel;
using System.ServiceModel.Web;

namespace CarRentals.Services.Interface
{
    [ServiceContract]
    public interface ICustomerRestService
    {

        [OperationContract]
        [WebGet(UriTemplate = "/Customer/GetById/{id}",
        RequestFormat = WebMessageFormat.Json,
        ResponseFormat = WebMessageFormat.Json)]
        string GetCustomerById(string id);

        [OperationContract]
        [WebGet(UriTemplate = "/Customer/GetAll",
        RequestFormat = WebMessageFormat.Json,
        ResponseFormat = WebMessageFormat.Json)]
        string GetAllCustomer();

        [OperationContract]
        [WebInvoke(Method = "POST",
        UriTemplate = "/Customer/Add",
        RequestFormat = WebMessageFormat.Json,
        ResponseFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.Bare)]
        void AddCustomer(Customer customer);

    }
}
