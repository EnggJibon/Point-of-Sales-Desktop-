using POS.BLL.Security.Domain;
using POS.DAL.Security;
using POS.DAL.Security.Repository;
using POS.UTILS.Infrastructure;
using POS.UTILS.Infrastructure.Contract;

namespace POS.BLL.Security
{
    public partial interface IApplicationPolicyService : IBaseService<ApplicationPolicyModel, ApplicationPolicy>
    {
    }

    public class ApplicationPolicyService : BaseService<ApplicationPolicyModel, ApplicationPolicy>, IApplicationPolicyService
    {
        private readonly IApplicationPolicyRepository _applicationPolicyRepository;

        public ApplicationPolicyService(IApplicationPolicyRepository applicationPolicyRepository)
            : base(applicationPolicyRepository)
        {
            _applicationPolicyRepository = applicationPolicyRepository;
        }
    }
}
