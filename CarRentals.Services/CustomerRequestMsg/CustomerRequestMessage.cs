using CarRentals.Domain;
using System.ServiceModel;

namespace CarRentals.Services.CustomerRequestMsg
{
    [MessageContract]
    public class CustomerRequestMessage
    {
        [MessageHeader]
        public string Key { get; set; }

        [MessageBodyMember]
        public Customer Customer { get; set; }
    }
}
