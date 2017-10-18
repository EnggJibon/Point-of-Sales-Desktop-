using System.Collections.Generic;
using System.Linq;
using POS.UTILS.Infrastructure;
using POS.UTILS.Infrastructure.Contract;

namespace POS.DAL.HRM.Repository
{
    public partial interface IDesignationRepository : IBaseRepository<Designation>
    {

    }

    public class DesignationRepository : BaseRepository<Designation, POS_HRM>, IDesignationRepository
    {
        private readonly POS_HRM _dbContextHRM;

        public DesignationRepository(IUnitOfWork unitOfWork)
            : base(unitOfWork)
        {
            _dbContextHRM = new POS_HRM();
        }

        public override IEnumerable<Designation> GetAll()
        {
            return base.GetAll().Where(w => !w.IsDeleted);
        }
    }
}
