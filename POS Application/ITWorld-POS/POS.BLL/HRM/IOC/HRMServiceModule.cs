using Ninject.Modules;
using POS.BLL.HRM.Service;

namespace POS.BLL.HRM.IOC 
{
	public partial class HRMServiceModule : NinjectModule
	{
		public override void Load()
        {
            Bind<IDepartmentService>().To<DepartmentService>();
            Bind<IDesignationService>().To<DesignationService>();
		}
	}
}

