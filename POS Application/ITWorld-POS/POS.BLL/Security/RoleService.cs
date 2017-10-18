using POS.BLL.Security.Domain;
using POS.DAL.Security;
using POS.DAL.Security.Repository;
using POS.UTILS.Infrastructure;
using POS.UTILS.Infrastructure.Contract;

namespace POS.BLL.Security
{
    public partial interface IRoleService : IBaseService<RoleModel, Role>
    {
    }

    public class RoleService : BaseService<RoleModel, Role>, IRoleService
    {
        private readonly IRoleRepository _roleRepository;

        public RoleService(IRoleRepository roleRepository)
            : base(roleRepository)
        {
            _roleRepository = roleRepository;
        }       
    }
}
