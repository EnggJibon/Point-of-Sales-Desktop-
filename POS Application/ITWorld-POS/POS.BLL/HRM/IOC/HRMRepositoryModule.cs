using Ninject.Modules;
using POS.DAL.HRM.Repository;

namespace POS.BLL.HRM.IOC
{
    public partial class HRMRepositoryModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IDepartmentRepository>().To<DepartmentRepository>();
            Bind<IDesignationRepository>().To<DesignationRepository>();
        }
    }
}

