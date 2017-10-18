using POS.UTILS.Infrastructure;

namespace POS.BLL.Security.Domain
{
    public class UserTypeModel : BaseDomainModel<UserTypeModel>
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
