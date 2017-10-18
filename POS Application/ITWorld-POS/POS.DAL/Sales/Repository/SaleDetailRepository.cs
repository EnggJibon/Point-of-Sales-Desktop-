using POS.DAL.Security;
using POS.UTILS.Infrastructure;
using POS.UTILS.Infrastructure.Contract;

namespace POS.DAL.Sales.Repository
{
    public partial interface ISaleDetailRepository : IBaseRepository<SaleDetail>
    {

    }

    public class SaleDetailRepository : BaseRepository<SaleDetail, POS_Security>, ISaleDetailRepository
    {
        public SaleDetailRepository(IUnitOfWork unitOfWork)
            : base(unitOfWork)
        {

        }
    }
}
