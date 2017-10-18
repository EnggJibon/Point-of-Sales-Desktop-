using POS.DAL.Security;
using POS.UTILS.Infrastructure;
using POS.UTILS.Infrastructure.Contract;

namespace POS.DAL.Sales.Repository
{
    public partial interface ISaleReturnReceiveDetailRepository : IBaseRepository<SaleReturnReceiveDetail>
    {

    }

    public class SaleReturnReceiveDetailRepository : BaseRepository<SaleReturnReceiveDetail, POS_Security>, ISaleReturnReceiveDetailRepository
    {
        public SaleReturnReceiveDetailRepository(IUnitOfWork unitOfWork)
            : base(unitOfWork)
        {

        }
    }
}
