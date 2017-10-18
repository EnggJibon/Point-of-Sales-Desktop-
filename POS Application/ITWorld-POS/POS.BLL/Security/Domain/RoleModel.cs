using POS.UTILS.Infrastructure;

namespace POS.BLL.Security.Domain
{
    public class RoleModel : BaseDomainModel<RoleModel>
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
