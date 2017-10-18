using System.Collections.Generic;
using System.Linq;
using System.Text;
using POS.UTILS.Infrastructure;
using POS.UTILS.Infrastructure.Contract;

namespace POS.DAL.Security.Repository
{
    public partial interface IAdditionalOperationPermissionRepository : IBaseRepository<AdditionalOperationPermission>
    {
        List<USP_GetAdditionalOperationPermissionList_Result> GetRoleWiseOperationPermissions(long? id, long? userId, long? screenOperationId);
    }

    public class AdditionalOperationPermissionRepository : BaseRepository<AdditionalOperationPermission, POS_Security>, IAdditionalOperationPermissionRepository
    {

        private readonly POS_Security _dbContextSecurity = new POS_Security();
        public AdditionalOperationPermissionRepository(IUnitOfWork unitOfWork)
            : base(unitOfWork)
        {

        }

        public List<USP_GetAdditionalOperationPermissionList_Result> GetRoleWiseOperationPermissions(long? id, long? userId, long? screenOperationId)
        {
            var query = new StringBuilder();
            query.Append("EXEC [Security].[USP_GetAdditionalOperationPermissionList] ");
            query.Append("'" + id + "', ");
            query.Append("'" + userId + "', ");
            query.Append("'" + screenOperationId + "'");

            string finalQuery = query.ToString().Contains("''") ? query.ToString().Replace("''", "NULL") : query.ToString();
            return _dbContextSecurity.Database.SqlQuery<USP_GetAdditionalOperationPermissionList_Result>(finalQuery).ToList();
        }

    }
}


