using POS.BLL.Inventory.Domain;
using POS.DAL.Inventory;
using POS.DAL.Inventory.Repository;
using POS.UTILS.Infrastructure;
using POS.UTILS.Infrastructure.Contract;

namespace POS.BLL.Inventory.Service
{
    public partial interface IProductPriceService : IBaseService<ProductPriceModel, ProductPrice>
    {
        //List<ProductPriceModel> GetAllProductPriceInformation();
    }

    public class ProductPriceService : BaseService<ProductPriceModel, ProductPrice>, IProductPriceService
    {
        private readonly IProductPriceRepository _productPriceRepository;

        public ProductPriceService(IProductPriceRepository productPriceRepository)
            : base(productPriceRepository)
        {
            _productPriceRepository = productPriceRepository;
        }

        //public List<ProductPriceModel> GetAllProductPriceInformation()
        //{
        //    var ProductPrices = _ProductPriceRepository.GetAllProductPriceInformation();
        //    return Mapper.Map<List<ProductPriceModel>>(ProductPrices);
        //}
    }
}
