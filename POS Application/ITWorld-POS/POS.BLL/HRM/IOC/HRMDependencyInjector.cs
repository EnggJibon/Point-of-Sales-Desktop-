using Ninject;
using POS.BLL.HRM.Mapping;
using POS.UTILS.Infrastructure.Contract;

namespace POS.BLL.HRM.IOC 
{
	public partial class HRMDependencyInjector : IDependencyInjector
	{
		public void Inject(object container)
        {
            var kernel = container as IKernel;
            
            kernel.Load<HRMRepositoryModule>();
            kernel.Load<HRMServiceModule>();

			HRMAutoMapperBootStrapper.Initialize();
         }
	}
}

