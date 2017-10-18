using POS.UTILS.Infrastructure;

namespace POS.BLL.Security.Domain
{
    public class ApplicationModel : BaseDomainModel<ApplicationModel>
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
