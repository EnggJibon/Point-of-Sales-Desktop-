using POS.UTILS.Infrastructure;

namespace POS.BLL.Inventory.Domain
{
    public class ProductUnitModel : BaseDomainModel<ProductUnitModel>
    {
        public string ProductUnitName { get; set; }
        public string Description { get; set; }
    }
}
