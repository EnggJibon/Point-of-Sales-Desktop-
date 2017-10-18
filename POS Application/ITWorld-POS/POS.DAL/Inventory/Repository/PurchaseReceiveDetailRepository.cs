using System.Collections.Generic;
using System.Linq;
using System.Text;
using POS.UTILS.Infrastructure;
using POS.UTILS.Infrastructure.Contract;

namespace POS.DAL.Inventory.Repository
{
    public partial interface IPurchaseReceiveDetailRepository : IBaseRepository<PurchaseReceiveDetail>
    {
        List<USP_GetAllPurchaseReceiveDetail_Result> GetAllPurchaseReceiveDetail(long purchaseReceiveId);
    }

    public class PurchaseReceiveDetailRepository : BaseRepository<PurchaseReceiveDetail, POS_Inventory>, IPurchaseReceiveDetailRepository
    {
        private readonly POS_Inventory _dbContextInventory;

        public PurchaseReceiveDetailRepository(IUnitOfWork unitOfWork)
            : base(unitOfWork)
        {
            _dbContextInventory = new POS_Inventory();
        }

        public List<USP_GetAllPurchaseReceiveDetail_Result> GetAllPurchaseReceiveDetail(long purchaseReceiveId)
        {
            var query = new StringBuilder();
            query.Append("EXEC [Inventory].[USP_GetAllPurchaseReceiveDetail] ");
            query.Append("'" + purchaseReceiveId + "'");

            string finalQuery = query.ToString().Contains("''")
                ? query.ToString().Replace("''", "NULL")
                : query.ToString();

            return _dbContextInventory.Database.SqlQuery<USP_GetAllPurchaseReceiveDetail_Result>(finalQuery).ToList();
        }
    }
}