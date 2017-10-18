using POS.UTILS.Infrastructure;
using POS.UTILS.Infrastructure.Contract;

namespace POS.DAL.Security.Repository
{
    public partial interface IRoleRepository : IBaseRepository<Role>
    {

    }

    public class RoleRepository : BaseRepository<Role, POS_Security>, IRoleRepository
    {
        public RoleRepository(IUnitOfWork unitOfWork)
            : base(unitOfWork)
        {

        }
    }
}
