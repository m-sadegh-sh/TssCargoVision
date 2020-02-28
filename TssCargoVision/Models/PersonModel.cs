using System.Runtime.Serialization;

namespace TssCargoVision.Models
{
    [DataContract(Namespace = "http://tss.ir/cargoVision/service/index")]
    public class PersonModel
    {
        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Code { get; set; }

        [DataMember]
        public string Address { get; set; }

        [DataMember]
        public string PostalCode { get; set; }

        [DataMember]
        public string AdditionalInformation { get; set; }
    }
}
