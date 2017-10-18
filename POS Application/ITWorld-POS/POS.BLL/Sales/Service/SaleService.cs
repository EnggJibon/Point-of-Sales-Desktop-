using POS.BLL.Sales.Domain;
using POS.DAL.Sales;
using POS.DAL.Sales.Repository;
using POS.UTILS.Infrastructure;
using POS.UTILS.Infrastructure.Contract;

namespace POS.BLL.Sales.Service
{
    public partial interface ISaleService : IBaseService<SaleModel, Sale>
    {
    }

    public class SaleService : BaseService<SaleModel, Sale>, ISaleService
    {
        private readonly ISaleRepository _saleRepository;

        public SaleService(ISaleRepository saleRepository)
            : base(saleRepository)
        {
            _saleRepository = saleRepository;
        }
    }
}
