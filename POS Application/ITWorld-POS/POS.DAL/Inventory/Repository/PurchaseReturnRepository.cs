using System.Collections.Generic;
using System.Linq;
using System.Text;
using POS.UTILS.Infrastructure;
using POS.UTILS.Infrastructure.Contract;

namespace POS.DAL.Inventory.Repository
{
    public partial interface IPurchaseReturnRepository : IBaseRepository<PurchaseReturn>
    {
    }

    public class PurchaseReturnRepository : BaseRepository<PurchaseReturn, POS_Inventory>, IPurchaseReturnRepository
    {
        private readonly POS_Inventory _dbContextInventory;

        public PurchaseReturnRepository(IUnitOfWork unitOfWork)
            : base(unitOfWork)
        {
            _dbContextInventory = new POS_Inventory();
        }
    }
}
