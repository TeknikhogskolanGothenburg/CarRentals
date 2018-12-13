using System;
using System.Runtime.Serialization;

namespace CarRentals.Domain
{
    [DataContract]
    public class Booking
    {
        [DataMember]
        public int ID { get; set; }
        [DataMember]
        public int CustomerID { get; set; }
        [DataMember]
        public int CarID { get; set; }
        [DataMember]
        public DateTime StartTime { get; set; }
        [DataMember]
        public DateTime EndTime { get; set; }
    }

}
