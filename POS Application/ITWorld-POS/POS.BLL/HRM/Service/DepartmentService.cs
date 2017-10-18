using POS.BLL.HRM.Domain;
using POS.DAL.HRM;
using POS.DAL.HRM.Repository;
using POS.UTILS.Infrastructure;
using POS.UTILS.Infrastructure.Contract;

namespace POS.BLL.HRM.Service
{
    public partial interface IDepartmentService : IBaseService<DepartmentModel, Department>
    {
    }

    public class DepartmentService : BaseService<DepartmentModel, Department>, IDepartmentService
    {
        private readonly IDepartmentRepository _departmentRepository;

        public DepartmentService(IDepartmentRepository departmentRepository)
            : base(departmentRepository)
        {
            _departmentRepository = departmentRepository;
        }
    }
}
