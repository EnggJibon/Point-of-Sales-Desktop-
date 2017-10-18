using POS.BLL.Sales.Domain;
using POS.DAL.Sales;
using POS.DAL.Sales.Repository;
using POS.UTILS.Infrastructure;
using POS.UTILS.Infrastructure.Contract;

namespace POS.BLL.Sales.Service
{
    public partial interface ISaleReturnReceiveDetailService : IBaseService<SaleReturnReceiveDetailModel, SaleReturnReceiveDetail>
    {
    }

    public class SaleReturnReceiveDetailService : BaseService<SaleReturnReceiveDetailModel, SaleReturnReceiveDetail>, ISaleReturnReceiveDetailService
    {
        private readonly ISaleReturnReceiveDetailRepository _saleReturnReceiveDetailRepository;

        public SaleReturnReceiveDetailService(ISaleReturnReceiveDetailRepository saleReturnReceiveDetailRepository)
            : base(saleReturnReceiveDetailRepository)
        {
            _saleReturnReceiveDetailRepository = saleReturnReceiveDetailRepository;
        }
    }
}
