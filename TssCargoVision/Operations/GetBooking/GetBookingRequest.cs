using System.Runtime.Serialization;

namespace TssCargoVision.Operations.GetBooking
{
    [DataContract(Namespace = "http://tss.ir/cargoVision/service/index")]
    public sealed class GetBookingRequest
    {
        [DataMember]
        public string UserName { get; set; }

        [DataMember]
        public string Password { get; set; }

        [DataMember]
        public string BookingNumber { get; set; }
    }
}
