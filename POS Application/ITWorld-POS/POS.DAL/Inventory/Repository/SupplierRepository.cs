using POS.UTILS.Infrastructure;
using POS.UTILS.Infrastructure.Contract;

namespace POS.DAL.Inventory.Repository
{
    public partial interface ISupplierRepository : IBaseRepository<Supplier>
    {

    }

    public class SupplierRepository : BaseRepository<Supplier, POS_Inventory>, ISupplierRepository
    {
        public SupplierRepository(IUnitOfWork unitOfWork)
            : base(unitOfWork)
        {

        }
    }
}
