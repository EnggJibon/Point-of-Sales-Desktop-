using POS.UTILS.Infrastructure;

namespace POS.BLL.HRM.Domain
{
    public class DepartmentModel : BaseDomainModel<DepartmentModel>
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
