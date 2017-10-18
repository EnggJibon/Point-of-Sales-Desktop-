using POS.UTILS.Infrastructure;

namespace POS.BLL.Security.Domain
{
    public class ScreenOperationModel : BaseDomainModel<ScreenOperationModel>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public long ScreenId { get; set; }
        public string ScreenTitle { get; set; }

    }
}
