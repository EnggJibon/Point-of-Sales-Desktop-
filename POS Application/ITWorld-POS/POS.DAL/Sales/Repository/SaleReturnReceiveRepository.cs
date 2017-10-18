using POS.DAL.Security;
using POS.UTILS.Infrastructure;
using POS.UTILS.Infrastructure.Contract;

namespace POS.DAL.Sales.Repository
{
    public partial interface ISaleReturnReceiveRepository : IBaseRepository<SaleReturnReceive>
    {

    }

    public class SaleReturnReceiveRepository : BaseRepository<SaleReturnReceive, POS_Security>, ISaleReturnReceiveRepository
    {
        public SaleReturnReceiveRepository(IUnitOfWork unitOfWork)
            : base(unitOfWork)
        {

        }
    }
}
