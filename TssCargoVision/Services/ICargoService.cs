using System.ServiceModel;
using System.Threading.Tasks;
using TssCargoVision.Operations.GetBookingList;
using TssCargoVision.Operations.GetBooking;
using TssCargoVision.Operations.GetDeliveryMessageList;
using TssCargoVision.Operations.GetDeliveryMessage;

namespace TssCargoVision.Services
{
    [ServiceContract(Namespace = "http://tss.ir/cargoVision/service/index")]
    public interface ICargoService
    {
        [OperationContract]
        Task<GetBookingListResponse> GetBookingList(GetBookingListRequest request);

        [OperationContract]
        Task<GetBookingResponse> GetBooking(GetBookingRequest request);

        [OperationContract]
        Task<GetDeliveryMessageListResponse> GetDeliveryMessageList(GetDeliveryMessageListRequest request);

        [OperationContract]
        Task<GetDeliveryMessageResponse> GetDeliveryMessage(GetDeliveryMessageRequest request);
    }
}
