using POS.UTILS.Infrastructure;
using POS.UTILS.Infrastructure.Contract;

namespace POS.DAL.Security.Repository
{
    public partial interface IApplicationRepository : IBaseRepository<Application>
    {

    }

    public class ApplicationRepository : BaseRepository<Application, POS_Security>, IApplicationRepository
    {
        public ApplicationRepository(IUnitOfWork unitOfWork)
            : base(unitOfWork)
        {

        }
    }
}
