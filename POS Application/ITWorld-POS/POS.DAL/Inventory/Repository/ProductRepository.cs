using System.Collections.Generic;
using System.Linq;
using System.Text;
using POS.UTILS.Infrastructure;
using POS.UTILS.Infrastructure.Contract;

namespace POS.DAL.Inventory.Repository
{
    public partial interface IProductRepository : IBaseRepository<Product>
    {
        List<USP_GetProductSearchResult_Result> GetProductSearchResult(long? productId, string productName, long? productCategoryId);
    }

    public class ProductRepository : BaseRepository<Product, POS_Inventory>, IProductRepository
    {
        private readonly POS_Inventory _dbContextInventory;

        public ProductRepository(IUnitOfWork unitOfWork)
            : base(unitOfWork)
        {
            _dbContextInventory = new POS_Inventory();
        }

        public List<USP_GetProductSearchResult_Result> GetProductSearchResult(long? productId, string productName, long? productCategoryId)
        {
            var query = new StringBuilder();
            query.Append("EXEC [Inventory].[USP_GetProductSearchResult] ");
            query.Append("'" + productId + "', ");
            query.Append("'" + productName + "', ");
            query.Append("'" + productCategoryId + "'");

            string finalQuery = query.ToString().Contains("''")
                ? query.ToString().Replace("''", "NULL")
                : query.ToString();

            return _dbContextInventory.Database.SqlQuery<USP_GetProductSearchResult_Result>(finalQuery).ToList();
        }
    }
}
