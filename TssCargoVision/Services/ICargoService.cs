using System.ServiceModel;
using System.Threading.Tasks;
using TssCargoVision.Operations.GetBooking;

namespace TssCargoVision.Services
{
    [ServiceContract(Namespace = "http://tss.ir/cargoVision/service/index")]
    public interface ICargoService
    {
        [OperationContract]
        Task<GetBookingResponse> GetBooking(GetBookingRequest request);
    }
}
