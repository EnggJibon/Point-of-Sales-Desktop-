using System;
using POS.UTILS.Infrastructure;

namespace POS.BLL.Inventory.Domain
{
    public class PurchaseReceiveModel : BaseDomainModel<PurchaseReceiveModel>
    {
        public string ReceiveNumber { get; set; }
        public System.DateTime ReceiveDate { get; set; }
        public string ReceivedBy { get; set; }
        public string ReceivedFrom { get; set; }
        public long ChallanId { get; set; }
        public string ChallanNumber { get; set; }
        public DateTime? ChallanDate { get; set; }
        public long? SupplierId { get; set; }
        public string SupplierName { get; set; }
        public string SupplierCode { get; set; }
        public string Description { get; set; }
    }
}
