using POS.UTILS.Infrastructure;

namespace POS.BLL.Inventory.Domain
{
    public class ProductPriceModel : BaseDomainModel<ProductPriceModel>
    {
        public long PurchaseReceiveDetailId { get; set; }
        public decimal PurchaseUnitPrice { get; set; }
        public decimal DiscountInPercentage { get; set; }
        public decimal ProductCost { get; set; }
        public decimal ProductSalePrice { get; set; }
        public string Description { get; set; }
    }
}
