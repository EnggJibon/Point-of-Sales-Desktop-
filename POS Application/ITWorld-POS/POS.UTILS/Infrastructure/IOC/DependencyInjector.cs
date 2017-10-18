using Ninject;
using POS.UTILS.Infrastructure.Contract;

namespace POS.UTILS.Infrastructure.IOC
{
    public class DependencyInjector : IDependencyInjector
    {
        public void Inject(object container)
        {
            var kernel = container as IKernel;
            kernel.Load<CommonModule>();
         }
    }
}
