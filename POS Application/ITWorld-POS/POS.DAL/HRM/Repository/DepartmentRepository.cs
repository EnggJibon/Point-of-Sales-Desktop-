using System.Collections.Generic;
using System.Linq;
using POS.UTILS.Infrastructure;
using POS.UTILS.Infrastructure.Contract;

namespace POS.DAL.HRM.Repository
{
    public partial interface IDepartmentRepository : IBaseRepository<Department>
    {

    }

    public class DepartmentRepository : BaseRepository<Department, POS_HRM>, IDepartmentRepository
    {
        public DepartmentRepository(IUnitOfWork unitOfWork): base(unitOfWork)
        {

        }

        public override IEnumerable<Department> GetAll()
        {
            return base.GetAll().Where(w => !w.IsDeleted);
        }
    }
}

