using System.Collections.Generic;
using AutoMapper;
using POS.BLL.Inventory.Domain;
using POS.DAL.Inventory;
using POS.DAL.Inventory.Repository;
using POS.UTILS.Infrastructure;
using POS.UTILS.Infrastructure.Contract;

namespace POS.BLL.Inventory.Service
{
    public partial interface IProductService : IBaseService<ProductModel, Product>
    {
        List<ProductSearchInformation> GetAllProductInformation(long? productId, string productName, long? productCategoryId);
    }

    public class ProductService : BaseService<ProductModel, Product>, IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
            : base(productRepository)
        {
            _productRepository = productRepository;
        }

        public List<ProductSearchInformation> GetAllProductInformation(long? productId, string productName, long? productCategoryId)
        {
            var products = _productRepository.GetProductSearchResult(productId, productName, productCategoryId);
            return Mapper.Map<List<ProductSearchInformation>>(products);
        }
    }
}
