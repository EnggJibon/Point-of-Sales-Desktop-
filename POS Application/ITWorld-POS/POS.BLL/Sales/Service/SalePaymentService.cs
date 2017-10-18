using POS.BLL.Sales.Domain;
using POS.DAL.Sales;
using POS.DAL.Sales.Repository;
using POS.UTILS.Infrastructure;
using POS.UTILS.Infrastructure.Contract;

namespace POS.BLL.Sales.Service
{
    public partial interface ISalePaymentService : IBaseService<SalePaymentModel, SalePayment>
    {
    }

    public class SalePaymentService : BaseService<SalePaymentModel, SalePayment>, ISalePaymentService
    {
        private readonly ISalePaymentRepository _salePaymentRepository;

        public SalePaymentService(ISalePaymentRepository salePaymentRepository)
            : base(salePaymentRepository)
        {
            _salePaymentRepository = salePaymentRepository;
        }
    }
}
