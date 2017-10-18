using POS.UTILS.Infrastructure;

namespace POS.BLL.HRM.Domain
{
    public class DesignationModel : BaseDomainModel<DesignationModel>
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
