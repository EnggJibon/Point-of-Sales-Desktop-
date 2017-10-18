using POS.UTILS.Infrastructure;
using POS.UTILS.Infrastructure.Contract;

namespace POS.DAL.Security.Repository
{
    public partial interface IAccessLogRepository : IBaseRepository<AccessLog>
    {

    }

    public class AccessLogRepository : BaseRepository<AccessLog, POS_Security>, IAccessLogRepository
    {
        public AccessLogRepository(IUnitOfWork unitOfWork)
            : base(unitOfWork)
        {

        }
    }
}
