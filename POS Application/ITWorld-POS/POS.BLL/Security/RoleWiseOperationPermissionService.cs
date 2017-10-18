using System.Collections.Generic;
using AutoMapper;
using POS.BLL.Security.Domain;
using POS.DAL.Security;
using POS.DAL.Security.Repository;
using POS.UTILS.Infrastructure;
using POS.UTILS.Infrastructure.Contract;

namespace POS.BLL.Security
{
    public partial interface IRoleWiseOperationPermissionService : IBaseService<RoleWiseOperationPermissionModel, RoleWiseOperationPermission>
    {
        List<RoleWiseOperationPermissionModel> GetRoleWiseOperationPermissionList(long? id, long? roleId, long? screenOperationId);
    }

    public class RoleWiseOperationPermissionService : BaseService<RoleWiseOperationPermissionModel, RoleWiseOperationPermission>, IRoleWiseOperationPermissionService
    {
        private readonly IRoleWiseOperationPermissionRepository _roleWiseOperationPermissionRepository;

        public RoleWiseOperationPermissionService(IRoleWiseOperationPermissionRepository roleWiseOperationPermissionRepository)
            : base(roleWiseOperationPermissionRepository)
        {
            _roleWiseOperationPermissionRepository = roleWiseOperationPermissionRepository;
        }

        public List<RoleWiseOperationPermissionModel> GetRoleWiseOperationPermissionList(long? id, long? roleId, long? screenOperationId)
        {
            var roleWiseOperationPermissionList = _roleWiseOperationPermissionRepository.GetRoleWiseOperationPermissions(id, roleId, screenOperationId);
            return Mapper.Map<List<RoleWiseOperationPermissionModel>>(roleWiseOperationPermissionList);
        }
    }
}
