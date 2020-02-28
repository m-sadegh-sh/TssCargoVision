using System.Runtime.Serialization;

namespace TssCargoVision.Operations.GetDeliveryMessage
{
    [DataContract(Namespace = "http://tss.ir/cargoVision/service/index")]
    public sealed class GetDeliveryMessageRequest
    {
        [DataMember]
        public string UserName { get; set; }

        [DataMember]
        public string Password { get; set; }

        [DataMember]
        public string BLNumber { get; set; }
    }
}
