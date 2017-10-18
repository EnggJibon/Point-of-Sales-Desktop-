using System.Collections.Generic;
using System.Linq;
using System.Text;
using POS.UTILS.Infrastructure;
using POS.UTILS.Infrastructure.Contract;

namespace POS.DAL.Inventory.Repository
{
    public partial interface IPurchaseChallanDetailRepository : IBaseRepository<PurchaseChallanDetail>
    {
        List<USP_GetAllPurchaseChallanDetail_Result> GetAllPurchaseChallanDetail(long purchaseChallanId);
    }

    public class PurchaseChallanDetailRepository : BaseRepository<PurchaseChallanDetail, POS_Inventory>, IPurchaseChallanDetailRepository
    {
        private readonly POS_Inventory _dbContextInventory;

        public PurchaseChallanDetailRepository(IUnitOfWork unitOfWork)
            : base(unitOfWork)
        {
            _dbContextInventory = new POS_Inventory();
        }

        public List<USP_GetAllPurchaseChallanDetail_Result> GetAllPurchaseChallanDetail(long purchaseChallanId)
        {
            var query = new StringBuilder();
            query.Append("EXEC [Inventory].[USP_GetAllPurchaseChallanDetail] ");
            query.Append("'" + purchaseChallanId + "'");

            string finalQuery = query.ToString().Contains("''")
                ? query.ToString().Replace("''", "NULL")
                : query.ToString();

            return _dbContextInventory.Database.SqlQuery<USP_GetAllPurchaseChallanDetail_Result>(finalQuery).ToList();
        }
    }
}