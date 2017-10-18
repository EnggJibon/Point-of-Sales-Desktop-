using POS.UTILS.Infrastructure;

namespace POS.BLL.Inventory.Domain
{
    public class PurchaseChallanModel : BaseDomainModel<PurchaseChallanModel>
    {
        public string ChallanNumber { get; set; }
        public System.DateTime ChallanDate { get; set; }
        public long SupplierId { get; set; }
        public string SupplierName { get; set; }
        public string SupplierCode { get; set; }
        public string OrderBy { get; set; }
        public string Description { get; set; }
    }
}
