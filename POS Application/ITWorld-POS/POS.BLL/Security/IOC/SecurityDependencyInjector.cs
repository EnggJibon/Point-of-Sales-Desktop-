using Ninject;
using POS.BLL.Security.Mapping;
using POS.UTILS.Infrastructure.Contract;

namespace POS.BLL.Security.IOC 
{
    public partial class SecurityDependencyInjector : IDependencyInjector
	{
		public void Inject(object container)
        {
            var kernel = container as IKernel;

            kernel.Load<SecurityRepositoryModule>();
            kernel.Load<SecurityServiceModule>();

            SecurityAutoMapperBootStrapper.Initialize();
         }
	}
}

