using POS.BLL.Security.Domain;
using POS.DAL.Security;
using POS.DAL.Security.Repository;
using POS.UTILS.Infrastructure;
using POS.UTILS.Infrastructure.Contract;

namespace POS.BLL.Security
{
    public partial interface IUserTypeService : IBaseService<UserTypeModel, UserType>
    {
    }

    public class UserTypeService : BaseService<UserTypeModel, UserType>, IUserTypeService
    {
        private readonly IUserTypeRepository _userTypeRepository;

        public UserTypeService(IUserTypeRepository userTypeRepository)
            : base(userTypeRepository)
        {
            _userTypeRepository = userTypeRepository;
        }
    }
}
