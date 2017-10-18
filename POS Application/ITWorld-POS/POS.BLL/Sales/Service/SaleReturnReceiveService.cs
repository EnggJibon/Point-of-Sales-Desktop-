using POS.BLL.Sales.Domain;
using POS.DAL.Sales;
using POS.DAL.Sales.Repository;
using POS.UTILS.Infrastructure;
using POS.UTILS.Infrastructure.Contract;

namespace POS.BLL.Sales.Service
{
    public partial interface ISaleReturnReceiveService : IBaseService<SaleReturnReceiveModel, SaleReturnReceive>
    {
    }

    public class SaleReturnReceiveService : BaseService<SaleReturnReceiveModel, SaleReturnReceive>, ISaleReturnReceiveService
    {
        private readonly ISaleReturnReceiveRepository _saleReturnReceiveRepository;

        public SaleReturnReceiveService(ISaleReturnReceiveRepository saleReturnReceiveRepository)
            : base(saleReturnReceiveRepository)
        {
            _saleReturnReceiveRepository = saleReturnReceiveRepository;
        }
    }
}
