using POS.DAL.Security;
using POS.UTILS.Infrastructure;
using POS.UTILS.Infrastructure.Contract;

namespace POS.DAL.Sales.Repository
{
    public partial interface ISalePaymentRepository : IBaseRepository<SalePayment>
    {

    }

    public class SalePaymentRepository : BaseRepository<SalePayment, POS_Security>, ISalePaymentRepository
    {
        public SalePaymentRepository(IUnitOfWork unitOfWork)
            : base(unitOfWork)
        {

        }
    }
}
