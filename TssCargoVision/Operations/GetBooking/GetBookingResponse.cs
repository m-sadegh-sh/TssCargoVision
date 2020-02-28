using System.Runtime.Serialization;
using TssCargoVision.Models;

namespace TssCargoVision.Operations.GetBooking
{
    [DataContract(Namespace = "http://tss.ir/cargoVision/service/index")]
    public sealed class GetBookingResponse
    {
        [DataMember]
        public string Status { get; set; }

        [DataMember]
        public int? ErrorCode { get; set; }

        [DataMember]
        public BookingInformationModel BookingInformation { get; set; }
    }
}
