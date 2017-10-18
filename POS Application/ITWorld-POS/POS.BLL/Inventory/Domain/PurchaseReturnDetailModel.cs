using POS.UTILS.Infrastructure;

namespace POS.BLL.Inventory.Domain
{
    public class PurchaseReturnDetailModel : BaseDomainModel<PurchaseReturnDetailModel>
    {
        public long PurchaseReturnId { get; set; }
        public long PurchaseReceiveDetailId { get; set; }
        public decimal ProductUnitPrice { get; set; }
        public int ProductQuantity { get; set; }
        public decimal TotalPrice { get; set; }
        public string Description { get; set; }
    }
}
