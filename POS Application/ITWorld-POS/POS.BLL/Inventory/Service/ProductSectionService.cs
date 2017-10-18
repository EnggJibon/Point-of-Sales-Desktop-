using POS.BLL.Inventory.Domain;
using POS.DAL.Inventory;
using POS.DAL.Inventory.Repository;
using POS.UTILS.Infrastructure;
using POS.UTILS.Infrastructure.Contract;

namespace POS.BLL.Inventory.Service
{
    public partial interface IProductSectionService : IBaseService<ProductSectionModel, ProductSection>
    {
    }

    public class ProductSectionService : BaseService<ProductSectionModel, ProductSection>, IProductSectionService
    {
        private readonly IProductSectionRepository _productSectionRepository;

        public ProductSectionService(IProductSectionRepository productSectionRepository)
            : base(productSectionRepository)
        {
            _productSectionRepository = productSectionRepository;
        }
    }
}
