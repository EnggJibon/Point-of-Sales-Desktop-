using POS.BLL.Inventory.Domain;
using POS.DAL.Inventory;
using POS.DAL.Inventory.Repository;
using POS.UTILS.Infrastructure;
using POS.UTILS.Infrastructure.Contract;

namespace POS.BLL.Inventory.Service
{
    public partial interface ISupplierService : IBaseService<SupplierModel, Supplier>
    {
    }

    public class SupplierService : BaseService<SupplierModel, Supplier>, ISupplierService
    {
        private readonly ISupplierRepository _supplierRepository;

        public SupplierService(ISupplierRepository supplierRepository)
            : base(supplierRepository)
        {
            _supplierRepository = supplierRepository;
        }
    }
}
