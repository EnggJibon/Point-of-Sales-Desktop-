using POS.UTILS.Infrastructure;
using POS.UTILS.Infrastructure.Contract;

namespace POS.DAL.Inventory.Repository
{
    public partial interface IProductUnitRepository : IBaseRepository<ProductUnit>
    {

    }

    public class ProductUnitRepository : BaseRepository<ProductUnit, POS_Inventory>, IProductUnitRepository
    {
        public ProductUnitRepository(IUnitOfWork unitOfWork)
            : base(unitOfWork)
        {

        }
    }
}
