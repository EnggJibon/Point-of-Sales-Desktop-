using POS.UTILS.Infrastructure;

namespace POS.BLL.Inventory.Domain
{
    public class ProductSectionModel : BaseDomainModel<ProductSectionModel>
    {
        public string ProductSectionName { get; set; }
        public string Description { get; set; }
    }
}
