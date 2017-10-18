using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using POS.UTILS.Infrastructure;
using POS.UTILS.Infrastructure.Contract;

namespace POS.DAL.Inventory.Repository
{
    public partial interface IProductStoreRepository : IBaseRepository<ProductStore>
    {
        int GenerateSerialForProductStoreDetail(long purchaseReceiveDetailId);
        List<USP_GetProductStoreInformation_Result> GetProductStoreInformation(long purchaseReceiveDetailId);
    }

    public class ProductStoreRepository : BaseRepository<ProductStore, POS_Inventory>, IProductStoreRepository
    {
        private readonly POS_Inventory _dbContextInventory;

        public ProductStoreRepository(IUnitOfWork unitOfWork)
            : base(unitOfWork)
        {
            _dbContextInventory = new POS_Inventory();
        }

        public int GenerateSerialForProductStoreDetail(long purchaseReceiveDetailId)
        {
            int numberOfProductDetails = _dbContextInventory.ProductStores.Count(s => s.PurchaseReceiveDetailId == purchaseReceiveDetailId);
            return numberOfProductDetails + 1;
        }

        public List<USP_GetProductStoreInformation_Result> GetProductStoreInformation(long purchaseReceiveDetailId)
        {
            var query = new StringBuilder();
            query.Append("EXEC [Inventory].[USP_GetProductStoreInformation] ");
            query.Append("'" + purchaseReceiveDetailId + "'");

            string finalQuery = query.ToString().Contains("''")
                ? query.ToString().Replace("''", "NULL")
                : query.ToString();

            return _dbContextInventory.Database.SqlQuery<USP_GetProductStoreInformation_Result>(finalQuery).ToList();
        }
    }
}
