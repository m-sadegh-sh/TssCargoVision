using System.Runtime.Serialization;

namespace TssCargoVision.Models
{
    [DataContract(Namespace = "http://tss.ir/cargoVision/service/index")]
    public class CompanyModel
    {
        [DataMember]
        public string NationalCode { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Nationality { get; set; }

        [DataMember]
        public string Address { get; set; }

        [DataMember]
        public string AdditionalInformation { get; set; }
    }
}
