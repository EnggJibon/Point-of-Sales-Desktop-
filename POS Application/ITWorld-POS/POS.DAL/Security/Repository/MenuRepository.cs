using System.Collections.Generic;
using System.Linq;
using POS.UTILS.Infrastructure;
using POS.UTILS.Infrastructure.Contract;

namespace POS.DAL.Security.Repository
{
    public partial interface IMenuRepository : IBaseRepository<Menu>
    {
        Menu GetMenu(long screenId);
        List<Menu> GetParentMenus();
    }

    public class MenuRepository : BaseRepository<Menu, POS_Security>, IMenuRepository
    {
        private readonly POS_Security _dbContextSecurity = new POS_Security();

        public MenuRepository(IUnitOfWork unitOfWork)
            : base(unitOfWork)
        {
        }

        public Menu GetMenu(long screenId)
        {
            return _dbContextSecurity.Menus.FirstOrDefault(m => m.ScreenId == screenId);
        }

        public List<Menu> GetParentMenus()
        {
            return _dbContextSecurity.Menus.Where(m => m.ScreenId == null).ToList();
        }
    }
}
