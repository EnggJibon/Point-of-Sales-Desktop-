using POS.DAL.Security;
using POS.UTILS.Infrastructure;
using POS.UTILS.Infrastructure.Contract;

namespace POS.DAL.Sales.Repository
{
    public partial interface ISaleRepository : IBaseRepository<Sale>
    {

    }

    public class SaleRepository : BaseRepository<Sale, POS_Security>, ISaleRepository
    {
        public SaleRepository(IUnitOfWork unitOfWork)
            : base(unitOfWork)
        {

        }
    }
}
