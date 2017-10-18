using POS.BLL.Sales.Domain;
using POS.DAL.Sales;
using POS.DAL.Sales.Repository;
using POS.UTILS.Infrastructure;
using POS.UTILS.Infrastructure.Contract;

namespace POS.BLL.Sales.Service
{
    public partial interface ISaleDetailService : IBaseService<SaleDetailModel, SaleDetail>
    {
    }

    public class SaleDetailService : BaseService<SaleDetailModel, SaleDetail>, ISaleDetailService
    {
        private readonly ISaleDetailRepository _saleDetailRepository;

        public SaleDetailService(ISaleDetailRepository saleDetailRepository)
            : base(saleDetailRepository)
        {
            _saleDetailRepository = saleDetailRepository;
        }
    }
}
