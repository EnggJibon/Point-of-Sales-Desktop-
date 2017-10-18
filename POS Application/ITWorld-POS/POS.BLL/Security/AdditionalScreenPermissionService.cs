using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using POS.BLL.Security.Domain;
using POS.DAL.Security;
using POS.DAL.Security.Repository;
using POS.UTILS.Infrastructure;
using POS.UTILS.Infrastructure.Contract;

namespace POS.BLL.Security
{
    public partial interface IAdditionalScreenPermissionService : IBaseService<AdditionalScreenPermissionModel, AdditionalScreenPermission>
    {
        List<AdditionalScreenPermissionModel> GetAdditionalScreenPermissionList(long? id, long? userId, long? moduleId, long? screenId);
        AdditionalScreenPermissionModel GetAdditionalScreenPermissionDetails(long id);
    }

    public class AdditionalScreenPermissionService : BaseService<AdditionalScreenPermissionModel, AdditionalScreenPermission>, IAdditionalScreenPermissionService
    {
        private readonly IAdditionalScreenPermissionRepository _additionalScreenPermissionRepository;

        public AdditionalScreenPermissionService(IAdditionalScreenPermissionRepository additionalScreenPermissionRepository)
            : base(additionalScreenPermissionRepository)
        {
            _additionalScreenPermissionRepository = additionalScreenPermissionRepository;
        }

        public List<AdditionalScreenPermissionModel> GetAdditionalScreenPermissionList(long? id, long? userId, long? moduleId, long? screenId)
        {
            var additionalScreenPermissionList = _additionalScreenPermissionRepository.GetAdditionalScreenPermissions(id, userId, moduleId, screenId);
            return Mapper.Map<List<AdditionalScreenPermissionModel>>(additionalScreenPermissionList);
        }

        public AdditionalScreenPermissionModel GetAdditionalScreenPermissionDetails(long id)
        {
            var screenPermission = _additionalScreenPermissionRepository.GetAdditionalScreenPermissions(id, null, null, null).FirstOrDefault();
            return Mapper.Map<AdditionalScreenPermissionModel>(screenPermission);
        }
    }
}


