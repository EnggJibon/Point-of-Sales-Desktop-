using System.Collections.Generic;
using System.Linq;
using System.Text;
using POS.UTILS.Infrastructure;
using POS.UTILS.Infrastructure.Contract;

namespace POS.DAL.Security.Repository
{

    public partial interface IRoleWiseOperationPermissionRepository : IBaseRepository<RoleWiseOperationPermission>
    {
        List<USP_GetRoleWiseOperationPermissionList_Result> GetRoleWiseOperationPermissions(long? id, long? roleId, long? screenOperationId);
    }

    public class RoleWiseOperationPermissionRepository : BaseRepository<RoleWiseOperationPermission, POS_Security>, IRoleWiseOperationPermissionRepository
    {
        private readonly POS_Security _dbContextSecurity = new POS_Security();

        public RoleWiseOperationPermissionRepository(IUnitOfWork unitOfWork)
            : base(unitOfWork)
        {

        }

        public List<USP_GetRoleWiseOperationPermissionList_Result> GetRoleWiseOperationPermissions(long? id, long? roleId, long? screenOperationId)
        {
            var query = new StringBuilder();
            query.Append("EXEC [Security].[USP_GetRoleWiseOperationPermissionList] ");
            query.Append("'" + id + "', ");
            query.Append("'" + roleId + "', ");
            query.Append("'" + screenOperationId + "'");

            string finalQuery = query.ToString().Contains("''") ? query.ToString().Replace("''", "NULL") : query.ToString();
            return _dbContextSecurity.Database.SqlQuery<USP_GetRoleWiseOperationPermissionList_Result>(finalQuery).ToList();
        }
    }
}
