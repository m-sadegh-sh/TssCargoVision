using System.Runtime.Serialization;

namespace TssCargoVision.Models
{
    [DataContract(Namespace = "http://tss.ir/cargoVision/service/index")]
    public class TerminalModel
    {
        [DataMember]
        public string ID { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public PlaceModel Place { get; set; }

        [DataMember]
        public string AdditionalInformation { get; set; }
    }
}
