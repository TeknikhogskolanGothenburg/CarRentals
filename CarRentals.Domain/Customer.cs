using System.Runtime.Serialization;

namespace CarRentals.Domain
{
    [DataContract]
    public class Customer
    {
        [DataMember(Order = 1, IsRequired = false)]
        public int ID { get; set; }

        [DataMember(Name = "FirstName",Order = 2)]
        public string FirstName { get; set; }

        [DataMember(Name = "LastName",Order = 3)]
        public string LastName { get; set; }

        [DataMember(Name = "PhoneNumber",Order = 4)]
        public string PhoneNumber { get; set; }

        [DataMember(Name = "Email",Order = 5)]
        public string Email { get; set; }
    }

}
