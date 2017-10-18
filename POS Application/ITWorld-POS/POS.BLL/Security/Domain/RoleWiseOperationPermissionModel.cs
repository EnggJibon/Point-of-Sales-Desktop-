using POS.UTILS.Infrastructure;

namespace POS.BLL.Security.Domain
{
    public class RoleWiseOperationPermissionModel : BaseDomainModel<RoleWiseOperationPermissionModel>
    {
        public long RoleId { get; set; }
        public long ScreenOperationId { get; set; }
        public bool HaveAccess { get; set; }
        public string ScreenOperationName { get; set; }
        public string RoleName { get; set; }
    }
}
