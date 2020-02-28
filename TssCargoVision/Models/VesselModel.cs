using System.Runtime.Serialization;

namespace TssCargoVision.Models
{
    [DataContract(Namespace = "http://tss.ir/cargoVision/service/index")]
    public class VesselModel
    {
        [DataMember]
        public string ID { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Nationality { get; set; }

        [DataMember]
        public string RegistrationNumber { get; set; }

        [DataMember]
        public string LoadCapacity { get; set; }

        [DataMember]
        public string EmptyWeight { get; set; }

        [DataMember]
        public string AdditionalInformation { get; set; }
    }
}
