using POS.UTILS.Infrastructure;
using POS.UTILS.Infrastructure.Contract;

namespace POS.DAL.Inventory.Repository
{
    public partial interface IPurchaseReturnDetailRepository : IBaseRepository<PurchaseReturnDetail>
    {

    }

    public class PurchaseReturnDetailRepository : BaseRepository<PurchaseReturnDetail, POS_Inventory>, IPurchaseReturnDetailRepository
    {
        public PurchaseReturnDetailRepository(IUnitOfWork unitOfWork)
            : base(unitOfWork)
        {

        }
    }
}