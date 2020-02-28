using System.Collections.Generic;
using System.Runtime.Serialization;
using TssCargoVision.Models;

namespace TssCargoVision.Operations.GetDeliveryMessageList
{
    [DataContract(Namespace = "http://tss.ir/cargoVision/service/index")]
    public sealed class GetDeliveryMessageListResponse
    {
        [DataMember]
        public string Status { get; set; }

        [DataMember]
        public int? ErrorCode { get; set; }

        [DataMember]
        public List<ItemModel> DeliveryMessageList { get; set; }
    }
}
