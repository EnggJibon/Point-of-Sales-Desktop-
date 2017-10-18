using POS.UTILS.Infrastructure;
using POS.UTILS.Infrastructure.Contract;

namespace POS.DAL.Security.Repository
{
    public partial interface IApplicationPolicyRepository : IBaseRepository<ApplicationPolicy>
    {

    }

    public class ApplicationPolicyRepository : BaseRepository<ApplicationPolicy, POS_Security>, IApplicationPolicyRepository
    {
        public ApplicationPolicyRepository(IUnitOfWork unitOfWork)
            : base(unitOfWork)
        {

        }
    }
}
