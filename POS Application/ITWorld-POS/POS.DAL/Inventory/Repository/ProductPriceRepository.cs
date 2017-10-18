using POS.UTILS.Infrastructure;
using POS.UTILS.Infrastructure.Contract;

namespace POS.DAL.Inventory.Repository
{
    public partial interface IProductPriceRepository : IBaseRepository<ProductPrice>
    {
        //List<USP_GetAllProductPriceInformation_Result> GetAllProductPriceInformation();
    }

    public class ProductPriceRepository : BaseRepository<ProductPrice, POS_Inventory>, IProductPriceRepository
    {
        private readonly POS_Inventory _dbContextInventory;

        public ProductPriceRepository(IUnitOfWork unitOfWork)
            : base(unitOfWork)
        {
            _dbContextInventory = new POS_Inventory();
        }

        //public List<USP_GetAllProductPriceInformation_Result> GetAllProductPriceInformation()
        //{
        //    return _dbContextInventory.Database.SqlQuery<USP_GetAllProductPriceInformation_Result>("EXEC [Inventory].[USP_GetAllProductPriceInformation]").ToList();
        //}
    }
}
