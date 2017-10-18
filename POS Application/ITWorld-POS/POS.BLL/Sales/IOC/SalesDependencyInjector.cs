using Ninject;
using POS.BLL.Sales.Mapping;
using POS.UTILS.Infrastructure.Contract;

namespace POS.BLL.Sales.IOC 
{
    public partial class SalesDependencyInjector : IDependencyInjector
	{
		public void Inject(object container)
        {
            var kernel = container as IKernel;

            kernel.Load<SalesRepositoryModule>();
            kernel.Load<SalesServiceModule>();

            SalesAutoMapperBootStrapper.Initialize();
         }
	}
}

