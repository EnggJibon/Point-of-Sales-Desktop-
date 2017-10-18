using Ninject.Modules;
using POS.DAL.Sales.Repository;

namespace POS.BLL.Sales.IOC
{
    public partial class SalesRepositoryModule : NinjectModule
    {
        public override void Load()
        {
            Bind<ISaleRepository>().To<SaleRepository>();
            Bind<ISaleDetailRepository>().To<SaleDetailRepository>();
            Bind<ISalePaymentRepository>().To<SalePaymentRepository>();
            Bind<ISaleReturnReceiveRepository>().To<SaleReturnReceiveRepository>();
            Bind<ISaleReturnReceiveDetailRepository>().To<SaleReturnReceiveDetailRepository>();
        }
    }
}

