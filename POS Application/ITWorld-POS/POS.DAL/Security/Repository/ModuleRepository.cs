using POS.UTILS.Infrastructure;
using POS.UTILS.Infrastructure.Contract;

namespace POS.DAL.Security.Repository
{
    public partial interface IModuleRepository : IBaseRepository<Module>
    {

    }

    public class ModuleRepository : BaseRepository<Module, POS_Security>, IModuleRepository
    {
        public ModuleRepository(IUnitOfWork unitOfWork)
            : base(unitOfWork)
        {

        }
    }
}
