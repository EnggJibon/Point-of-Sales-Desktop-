using Ninject;
using POS.BLL.HRM.IOC;
using POS.BLL.Inventory.IOC;
using POS.BLL.Sales.IOC;
using POS.BLL.Security.IOC;
using POS.UTILS.Infrastructure.Contract;
using POS.UTILS.Infrastructure.IOC;

namespace POS.BLL
{
    public class BootStrapper
    {
        public static IKernel Initialize()
        {   
            IKernel kernel = new StandardKernel();
            ConfigureGeneric(kernel);
            ConfigureSecurityModule(kernel);
            ConfigureHRMModule(kernel);
            ConfigureInventoryModule(kernel);
            ConfigureSalesModule(kernel);
            return kernel;
        }

        private static IKernel ConfigureGeneric(IKernel kernel)
        {
            IDependencyInjector injector = new DependencyInjector();
            injector.Inject(kernel);
            AutoMapperBootstrapper.Initialize(kernel);
            return kernel;
        }

        private static IKernel ConfigureSecurityModule(IKernel kernel)
        {
            IDependencyInjector injector = new SecurityDependencyInjector();
            injector.Inject(kernel);
            return kernel;
        }

        private static IKernel ConfigureHRMModule(IKernel kernel)
        {
            IDependencyInjector injector = new HRMDependencyInjector();
            injector.Inject(kernel);
            return kernel;
        }

        private static IKernel ConfigureInventoryModule(IKernel kernel)
        {
            IDependencyInjector injector = new InventoryDependencyInjector();
            injector.Inject(kernel);
            return kernel;
        }

        private static IKernel ConfigureSalesModule(IKernel kernel)
        {
            IDependencyInjector injector = new SalesDependencyInjector();
            injector.Inject(kernel);
            return kernel;
        }
    }
}
