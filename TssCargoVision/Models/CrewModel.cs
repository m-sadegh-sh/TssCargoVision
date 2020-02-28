using System.Runtime.Serialization;

namespace TssCargoVision.Models
{
    [DataContract(Namespace = "http://tss.ir/cargoVision/service/index")]
    public class CrewModel
    {
        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Code { get; set; }

        [DataMember]
        public string Rank { get; set; }

        [DataMember]
        public string AdditionalInformation { get; set; }
    }
}
