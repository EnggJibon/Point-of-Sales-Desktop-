using POS.UTILS.Infrastructure;
using POS.UTILS.Infrastructure.Contract;

namespace POS.DAL.Security.Repository
{
    public partial interface IUserTypeRepository : IBaseRepository<UserType>
    {

    }

    public class UserTypeRepository : BaseRepository<UserType, POS_Security>, IUserTypeRepository
    {
        public UserTypeRepository(IUnitOfWork unitOfWork)
            : base(unitOfWork)
        {

        }
    }
}
