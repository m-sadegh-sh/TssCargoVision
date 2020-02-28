using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Threading.Tasks;
using TssCargoVision.Models;
using TssCargoVision.Operations.GetBooking;
using TssCargoVision.Wsdl;

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

        public async Task<GetBookingResponse> GetBooking(GetBookingRequest request)
        {
            return new GetBookingResponse
            {
                Status = "OK",
                ErrorCode = null,
                BookingInformation = new BookingInformationModel
                {
                    VersionNumber = "1",
                    BookingNumber = "1023",
                    ManifestNumber = "112",
                    RegistrationDate = 12221455,
                    PermitType = "A",
                    ShippingCompany = new CompanyModel
                    {
                        NationalCode = "124453",
                        Name = "Iran Air Tour"
                    },
                    ShippingAgentCompany = new CompanyModel
                    {
                        NationalCode = "1222221",
                        Name = "Avang Agency"
                    },
                    Terminal = new TerminalModel
                    {
                        ID = "10",
                        Name = "HNM",
                        Place = new PlaceModel
                        {
                            Country = "IR",
                            City = "Mashhad",
                            PostalCode = "123123123",
                            Address = "Mashhad, HNM"
                        }
                    },
                    Vessel = new VesselModel
                    {
                        Name = "Boeing 777 Max"
                    },
                    Captain = new CrewModel
                    {
                        Name = "Jahanian",
                        Rank = "Cap"
                    },
                    CrewList = new List<CrewModel>
                    {
                        new CrewModel
                        {
                            Name = "Jahanian",
                            Rank = "Cap"
                        },
                        new CrewModel
                        {
                            Name = "Bilian",
                            Rank = "Sup"
                        }
                    }
                }
            };
            //return await _wsdlClient.InvokeAsync<GetBookingRequest, GetBookingResponse>(
            //    request
            //);
        }
    }
}
