using System.Runtime.Serialization;

namespace TssCargoVision.Models
{
    [DataContract(Namespace = "http://tss.ir/cargoVision/service/index")]
    public class ItemModel
    {
        [DataMember]
        public int? Number { get; set; }

        [DataMember]
        public string Action { get; set; }

        [DataMember]
        public int? ActionTime { get; set; }
    }
}
