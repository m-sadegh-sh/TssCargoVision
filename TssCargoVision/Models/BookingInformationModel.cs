using System.Collections.Generic;
using System.Runtime.Serialization;

namespace TssCargoVision.Models
{
    [DataContract(Namespace = "http://tss.ir/cargoVision/service/index")]
    public class BookingInformationModel
    {
        [DataMember]
        public string VersionNumber { get; set; }

        [DataMember]
        public string BookingNumber { get; set; }

        [DataMember]
        public string ManifestNumber { get; set; }

        [DataMember]
        public long RegistrationDate { get; set; }

        [DataMember]
        public string PermitType { get; set; }

        [DataMember]
        public CompanyModel ShippingCompany { get; set; }

        [DataMember]
        public CompanyModel ShippingAgentCompany { get; set; }

        [DataMember]
        public TerminalModel Terminal { get; set; }

        [DataMember]
        public VesselModel Vessel { get; set; }

        [DataMember]
        public CrewModel Captain { get; set; }

        [DataMember]
        public List<CrewModel> CrewList { get; set; }
    }
}
