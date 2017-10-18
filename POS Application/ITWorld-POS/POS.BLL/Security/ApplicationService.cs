using POS.BLL.Security.Domain;
using POS.DAL.Security;
using POS.DAL.Security.Repository;
using POS.UTILS.Infrastructure;
using POS.UTILS.Infrastructure.Contract;

namespace POS.BLL.Security
{
    public partial interface IApplicationService : IBaseService<ApplicationModel, Application>
    {
    }

    public class ApplicationService : BaseService<ApplicationModel, Application>, IApplicationService
    {
        private readonly IApplicationRepository _applicationRepository;

        public ApplicationService(IApplicationRepository applicationRepository)
            : base(applicationRepository)
        {
            _applicationRepository = applicationRepository;
        }
    }
}
