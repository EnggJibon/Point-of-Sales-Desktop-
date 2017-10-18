using POS.UTILS.Infrastructure;

namespace POS.BLL.Inventory.Domain
{
    public class PurchaseReceiveDetailModel : BaseDomainModel<PurchaseReceiveDetailModel>
    {
        public long PurchaseReceiveId { get; set; }
        public long PurchaseChallanDetailId { get; set; }
        public long ProductId { get; set; }
        public string ProductName { get; set; }
        public long SupplierId { get; set; }
        public string SupplierName { get; set; }
        public long ProductCategoryId { get; set; }
        public string ProductCategoryName { get; set; }
        public decimal ProductUnitPrice { get; set; }
        public int ProductQuantity { get; set; }
        public decimal TotalPrice { get; set; }
        public string Description { get; set; }
    }
}
