using POS.UTILS.Infrastructure;

namespace POS.BLL.Inventory.Domain
{
    public class ProductCategoryModel : BaseDomainModel<ProductCategoryModel>
    {
        public string ProductCategoryName { get; set; }
        public string Description { get; set; }
    }
}
