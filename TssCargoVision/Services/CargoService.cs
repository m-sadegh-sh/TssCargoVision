using Microsoft.Extensions.Logging;
using System.Threading.Tasks;
using TssCargoVision.Operations.GetBookingList;
using TssCargoVision.Operations.GetBooking;
using TssCargoVision.Operations.GetDeliveryMessageList;
using TssCargoVision.Operations.GetDeliveryMessage;
using TssCargoVision.Wsdl;
using TssCargoVision.Operations;

namespace TssCargoVision.Services
{
    public class CargoService : ICargoService
    {
        private readonly ILogger<CargoService> _logger;
        private readonly WsdlClient _wsdlClient;

        public CargoService(ILogger<CargoService> logger, WsdlClient wsdlClient)
        {
            _logger = logger;
            _wsdlClient = wsdlClient;
        }

        public async Task<GetBookingListResponse> GetBookingList(GetBookingListRequest request)
        {
            return await _wsdlClient.PostAsJsonAsync<GetBookingListResponse>(
                TssRequest.Create("GetBookingList", request)
            );
        }

        public async Task<GetBookingResponse> GetBooking(GetBookingRequest request)
        {
            return await _wsdlClient.PostAsJsonAsync<GetBookingResponse>(
                TssRequest.Create("GetBooking", request)
            );
        }

        public async Task<GetDeliveryMessageListResponse> GetDeliveryMessageList(GetDeliveryMessageListRequest request)
        {
            return await _wsdlClient.PostAsJsonAsync<GetDeliveryMessageListResponse>(
                TssRequest.Create("GetDeliveryMessageList", request)
            );
        }

        public async Task<GetDeliveryMessageResponse> GetDeliveryMessage(GetDeliveryMessageRequest request)
        {
            return await _wsdlClient.PostAsJsonAsync<GetDeliveryMessageResponse>(
                TssRequest.Create("GetDeliveryMessage", request)
            );
        }
    }
}
