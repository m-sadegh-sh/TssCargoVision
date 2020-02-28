using System.Runtime.Serialization;
using TssCargoVision.Models;

namespace TssCargoVision.Operations.GetDeliveryMessage
{
    [DataContract(Namespace = "http://tss.ir/cargoVision/service/index")]
    public sealed class GetDeliveryMessageResponse
    {
        [DataMember]
        public string Status { get; set; }

        [DataMember]
        public int? ErrorCode { get; set; }

        [DataMember]
        public DeliveryMessageModel DeliveryMessage { get; set; }
    }
}
