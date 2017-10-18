using POS.BLL.Inventory.Domain;
using POS.DAL.Inventory;
using POS.DAL.Inventory.Repository;
using POS.UTILS.Infrastructure;
using POS.UTILS.Infrastructure.Contract;

namespace POS.BLL.Inventory.Service
{
    public partial interface IProductCategoryService : IBaseService<ProductCategoryModel, ProductCategory>
    {
    }

    public class ProductCategoryService : BaseService<ProductCategoryModel, ProductCategory>, IProductCategoryService
    {
        private readonly IProductCategoryRepository _productCategoryRepository;

        public ProductCategoryService(IProductCategoryRepository productCategoryRepository)
            : base(productCategoryRepository)
        {
            _productCategoryRepository = productCategoryRepository;
        }
    }
}
