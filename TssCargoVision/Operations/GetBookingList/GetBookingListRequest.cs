using System.Runtime.Serialization;

namespace TssCargoVision.Operations.GetBookingList
{
    [DataContract(Namespace = "http://tss.ir/cargoVision/service/index")]
    public sealed class GetBookingListRequest
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
