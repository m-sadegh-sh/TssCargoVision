using System.Runtime.Serialization;

namespace TssCargoVision.Models
{
    [DataContract(Namespace = "http://tss.ir/cargoVision/service/index")]
    public class DeliveryMessageModel
    {
        [DataMember]
        public string DeliveryMassageNumber { get; set; }

        [DataMember]
        public string BLNumber { get; set; }

        [DataMember]
        public long DischargeApprovalDate { get; set; }

        [DataMember]
        public CompanyModel ShippingCompany { get; set; }

        [DataMember]
        public PlaceModel DischargePlace { get; set; }

        [DataMember]
        public PersonModel Consignee { get; set; }
    }
}
