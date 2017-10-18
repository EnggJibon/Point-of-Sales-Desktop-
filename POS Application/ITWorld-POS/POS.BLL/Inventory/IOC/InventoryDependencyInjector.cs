using Ninject;
using POS.BLL.Inventory.Mapping;
using POS.UTILS.Infrastructure.Contract;

namespace POS.BLL.Inventory.IOC 
{
    public partial class InventoryDependencyInjector : IDependencyInjector
	{
		public void Inject(object container)
        {
            var kernel = container as IKernel;

            kernel.Load<InventoryRepositoryModule>();
            kernel.Load<InventoryServiceModule>();

            InventoryAutoMapperBootStrapper.Initialize();
         }
	}
}

