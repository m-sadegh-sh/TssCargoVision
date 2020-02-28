using System.Collections.Generic;
using System.Runtime.Serialization;
using TssCargoVision.Models;

namespace TssCargoVision.Operations.GetBookingList
{
    [DataContract(Namespace = "http://tss.ir/cargoVision/service/index")]
    public sealed class GetBookingListResponse
    {
        [DataMember]
        public string Status { get; set; }

        [DataMember]
        public int? ErrorCode { get; set; }

        [DataMember]
        public List<ItemModel> BookingList { get; set; }
    }
}
