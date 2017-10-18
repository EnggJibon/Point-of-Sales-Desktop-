using System.Collections.Generic;
using System.Linq;
using System.Text;
using POS.UTILS.Infrastructure;
using POS.UTILS.Infrastructure.Contract;

namespace POS.DAL.Security.Repository
{
    public partial interface IAdditionalScreenPermissionRepository : IBaseRepository<AdditionalScreenPermission>
    {
        List<USP_GetAdditionalScreenPermissionList_Result> GetAdditionalScreenPermissions(long? id, long? userId, long? moduleId, long? screenId);
    }

    public class AdditionalScreenPermissionRepository : BaseRepository<AdditionalScreenPermission, POS_Security>, IAdditionalScreenPermissionRepository
    {
        private readonly POS_Security _dbContextSecurity = new POS_Security();
        public AdditionalScreenPermissionRepository(IUnitOfWork unitOfWork)
            : base(unitOfWork)
        {

        }

        public List<USP_GetAdditionalScreenPermissionList_Result> GetAdditionalScreenPermissions(long? id, long? userId, long? moduleId, long? screenId)
        {
            var query = new StringBuilder();
            query.Append("EXEC [Security].[USP_GetAdditionalScreenPermissionList] ");
            query.Append("'" + id + "', '" + userId + "', ");
            query.Append("'" + moduleId + "', '" + screenId + "'");

            string finalQuery = query.ToString().Contains("''")
                ? query.ToString().Replace("''", "NULL")
                : query.ToString();

            return _dbContextSecurity.Database.SqlQuery<USP_GetAdditionalScreenPermissionList_Result>(finalQuery).ToList();
        }
    }
}





