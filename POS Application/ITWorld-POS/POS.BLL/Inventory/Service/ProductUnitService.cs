using POS.BLL.Inventory.Domain;
using POS.DAL.Inventory;
using POS.DAL.Inventory.Repository;
using POS.UTILS.Infrastructure;
using POS.UTILS.Infrastructure.Contract;

namespace POS.BLL.Inventory.Service
{
    public partial interface IProductUnitService : IBaseService<ProductUnitModel, ProductUnit>
    {
    }

    public class ProductUnitService : BaseService<ProductUnitModel, ProductUnit>, IProductUnitService
    {
        private readonly IProductUnitRepository _productUnitRepository;

        public ProductUnitService(IProductUnitRepository productUnitRepository)
            : base(productUnitRepository)
        {
            _productUnitRepository = productUnitRepository;
        }
    }
}
