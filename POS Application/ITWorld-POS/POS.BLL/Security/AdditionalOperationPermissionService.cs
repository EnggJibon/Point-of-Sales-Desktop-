using System.Collections.Generic;
using AutoMapper;
using POS.BLL.Security.Domain;
using POS.DAL.Security;
using POS.DAL.Security.Repository;
using POS.UTILS.Infrastructure;
using POS.UTILS.Infrastructure.Contract;

namespace POS.BLL.Security
{
    public partial interface IAdditionalOperationPermissionService : IBaseService<AdditionalOperationPermissionModel, AdditionalOperationPermission>
    {
        List<AdditionalOperationPermissionModel> GetAdditionalOperationPermissionList(long? id, long? userId, long? screenOperationId);
    }

    public  class AdditionalOperationPermissionService : BaseService<AdditionalOperationPermissionModel, AdditionalOperationPermission>, IAdditionalOperationPermissionService
    {
         private readonly IAdditionalOperationPermissionRepository _additionalOperationPermissionRepository;

         public AdditionalOperationPermissionService(IAdditionalOperationPermissionRepository additionalOperationPermissionRepository)
             : base(additionalOperationPermissionRepository)
        {
            _additionalOperationPermissionRepository = additionalOperationPermissionRepository;
        }

         public List<AdditionalOperationPermissionModel> GetAdditionalOperationPermissionList(long? id, long? userId, long? screenOperationId)
         {
             var additionalOperationPermissionList = _additionalOperationPermissionRepository.GetRoleWiseOperationPermissions(id, userId, screenOperationId);
             return Mapper.Map<List<AdditionalOperationPermissionModel>>(additionalOperationPermissionList);
         }
    }
}
