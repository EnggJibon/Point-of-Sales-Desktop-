using System.Collections.Generic;
using System.Linq;
using System.Text;
using POS.UTILS.Infrastructure;
using POS.UTILS.Infrastructure.Contract;

namespace POS.DAL.Inventory.Repository
{
    public partial interface IPurchaseChallanRepository : IBaseRepository<PurchaseChallan>
    {
        List<USP_GetAllPurchaseChallan_Result> GetAllPurchaseChallan();
    }

    public class PurchaseChallanRepository : BaseRepository<PurchaseChallan, POS_Inventory>, IPurchaseChallanRepository
    {
        private readonly POS_Inventory _dbContextInventory;

        public PurchaseChallanRepository(IUnitOfWork unitOfWork)
            : base(unitOfWork)
        {
            _dbContextInventory = new POS_Inventory();
        }

        public List<USP_GetAllPurchaseChallan_Result> GetAllPurchaseChallan()
        {
            var query = new StringBuilder();
            query.Append("EXEC [Inventory].[USP_GetAllPurchaseChallan]");

            string finalQuery = query.ToString().Contains("''")
                ? query.ToString().Replace("''", "NULL")
                : query.ToString();

            return _dbContextInventory.Database.SqlQuery<USP_GetAllPurchaseChallan_Result>(finalQuery).ToList();
        }
    }
}
