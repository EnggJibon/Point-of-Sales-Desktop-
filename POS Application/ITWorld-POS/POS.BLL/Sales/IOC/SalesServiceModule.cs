using Ninject.Modules;
using POS.BLL.Sales.Service;

namespace POS.BLL.Sales.IOC 
{
    public partial class SalesServiceModule : NinjectModule
	{
		public override void Load()
        {
            Bind<ISaleService>().To<SaleService>();
            Bind<ISaleDetailService>().To<SaleDetailService>();
            Bind<ISalePaymentService>().To<SalePaymentService>();
            Bind<ISaleReturnReceiveService>().To<SaleReturnReceiveService>();
            Bind<ISaleReturnReceiveDetailService>().To<SaleReturnReceiveDetailService>();
		}
	}
}

