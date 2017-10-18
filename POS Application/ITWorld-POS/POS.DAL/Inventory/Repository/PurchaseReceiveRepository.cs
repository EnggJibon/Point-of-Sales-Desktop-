using System.Collections.Generic;
using System.Linq;
using System.Text;
using POS.UTILS.Infrastructure;
using POS.UTILS.Infrastructure.Contract;

namespace POS.DAL.Inventory.Repository
{
    public partial interface IPurchaseReceiveRepository : IBaseRepository<PurchaseReceive>
    {
        List<USP_GetAllPurchaseReceive_Result> GetAllPurchaseReceive();
    }

    public class PurchaseReceiveRepository : BaseRepository<PurchaseReceive, POS_Inventory>, IPurchaseReceiveRepository
    {
        private readonly POS_Inventory _dbContextInventory;

        public PurchaseReceiveRepository(IUnitOfWork unitOfWork)
            : base(unitOfWork)
        {
            _dbContextInventory = new POS_Inventory();
        }

        public List<USP_GetAllPurchaseReceive_Result> GetAllPurchaseReceive()
        {
            var query = new StringBuilder();
            query.Append("EXEC [Inventory].[USP_GetAllPurchaseReceive]");

            string finalQuery = query.ToString().Contains("''")
                ? query.ToString().Replace("''", "NULL")
                : query.ToString();

            return _dbContextInventory.Database.SqlQuery<USP_GetAllPurchaseReceive_Result>(finalQuery).ToList();
        }
    }
}
