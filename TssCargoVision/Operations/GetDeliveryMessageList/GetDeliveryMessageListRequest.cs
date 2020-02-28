using System.Runtime.Serialization;

namespace TssCargoVision.Operations.GetDeliveryMessageList
{
    [DataContract(Namespace = "http://tss.ir/cargoVision/service/index")]
    public sealed class GetDeliveryMessageListRequest
    {
        [DataMember]
        public string UserName { get; set; }

        [DataMember]
        public string Password { get; set; }

        [DataMember]
        public long DateFrom { get; set; }

        [DataMember]
        public long DateTo { get; set; }
    }
}
