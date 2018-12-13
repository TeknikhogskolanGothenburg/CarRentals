using System.Runtime.Serialization;

namespace CarRentals.Domain
{
    [DataContract]
    public class Car
    {
        [DataMember]
        public int ID { get; set; }
        [DataMember]
        public string RegistrationNo { get; set; }
        [DataMember]
        public string Brand { get; set; }
        [DataMember]
        public string CarModel { get; set; }
        [DataMember]
        public int ManufacturingYear { get; set; }
        [DataMember]
        public string Status { get; set; }
    
    }
}


