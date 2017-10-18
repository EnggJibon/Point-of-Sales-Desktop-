using POS.UTILS.Infrastructure;
using POS.UTILS.Infrastructure.Contract;

namespace POS.DAL.Inventory.Repository
{
    public partial interface IProductSectionRepository : IBaseRepository<ProductSection>
    {

    }

    public class ProductSectionRepository : BaseRepository<ProductSection, POS_Inventory>, IProductSectionRepository
    {
        public ProductSectionRepository(IUnitOfWork unitOfWork)
            : base(unitOfWork)
        {

        }
    }
}
