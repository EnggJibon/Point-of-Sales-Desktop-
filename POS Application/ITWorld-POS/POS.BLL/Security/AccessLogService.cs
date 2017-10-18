using POS.BLL.Security.Domain;
using POS.DAL.Security;
using POS.DAL.Security.Repository;
using POS.UTILS.Infrastructure;
using POS.UTILS.Infrastructure.Contract;

namespace POS.BLL.Security
{
    public partial interface IAccessLogService : IBaseService<AccessLogModel, AccessLog>
    {
    }

    public class AccessLogService : BaseService<AccessLogModel, AccessLog>, IAccessLogService
    {
        private readonly IAccessLogRepository _accessLogRepository;

        public AccessLogService(IAccessLogRepository accessLogRepository)
            : base(accessLogRepository)
        {
            _accessLogRepository = accessLogRepository;
        }
    }
}
