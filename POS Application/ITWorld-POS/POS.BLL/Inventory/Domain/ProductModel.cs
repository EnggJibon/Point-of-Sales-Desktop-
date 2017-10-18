using POS.UTILS.Infrastructure;

namespace POS.BLL.Inventory.Domain
{
    public class ProductModel : BaseDomainModel<ProductModel>
    {
        public string ProductName { get; set; }
        public long ProductCategoryId { get; set; }
        public string Description { get; set; }
    }
}
