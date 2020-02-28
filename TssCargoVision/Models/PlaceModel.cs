using System.Runtime.Serialization;

namespace TssCargoVision.Models
{
    [DataContract(Namespace = "http://tss.ir/cargoVision/service/index")]
    public class PlaceModel
    {
        [DataMember]
        public string Country { get; set; }

        [DataMember]
        public string City { get; set; }

        [DataMember]
        public string PostalCode { get; set; }

        [DataMember]
        public string Address { get; set; }
    }
}
