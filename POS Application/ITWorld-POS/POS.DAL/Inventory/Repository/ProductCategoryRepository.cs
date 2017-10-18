using POS.UTILS.Infrastructure;
using POS.UTILS.Infrastructure.Contract;

namespace POS.DAL.Inventory.Repository
{
    public partial interface IProductCategoryRepository : IBaseRepository<ProductCategory>
    {

    }

    public class ProductCategoryRepository : BaseRepository<ProductCategory, POS_Inventory>, IProductCategoryRepository
    {
        public ProductCategoryRepository(IUnitOfWork unitOfWork)
            : base(unitOfWork)
        {

        }
    }
}

