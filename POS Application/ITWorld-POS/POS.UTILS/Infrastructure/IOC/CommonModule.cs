using Ninject.Modules;
using POS.UTILS.Infrastructure.Contract;

namespace POS.UTILS.Infrastructure.IOC
{
    public class CommonModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IUnitOfWork>().To<UnitOfWork>();
            Bind<IConnectionStringProvider>().To<ConnectionStringProvider>();
        }
    }
}
