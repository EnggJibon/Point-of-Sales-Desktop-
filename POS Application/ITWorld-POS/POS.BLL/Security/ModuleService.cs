using POS.BLL.Security.Domain;
using POS.DAL.Security;
using POS.DAL.Security.Repository;
using POS.UTILS.Infrastructure;
using POS.UTILS.Infrastructure.Contract;

namespace POS.BLL.Security
{
    public partial interface IModuleService : IBaseService<ModuleModel, Module>
    {
    }

    public class ModuleService : BaseService<ModuleModel, Module>, IModuleService
    {
        private readonly IModuleRepository _moduleRepository;

        public ModuleService(IModuleRepository moduleRepository)
            : base(moduleRepository)
        {
            _moduleRepository = moduleRepository;
        }
    }
}
