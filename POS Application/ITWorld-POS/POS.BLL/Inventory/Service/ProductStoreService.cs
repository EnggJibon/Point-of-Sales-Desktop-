using System;
using System.Collections.Generic;
using AutoMapper;
using POS.BLL.Inventory.Domain;
using POS.DAL.Inventory;
using POS.DAL.Inventory.Repository;
using POS.UTILS.Infrastructure;
using POS.UTILS.Infrastructure.Contract;

namespace POS.BLL.Inventory.Service
{
    public partial interface IProductStoreService : IBaseService<ProductStoreModel, ProductStore>
    {
        int GenerateSerialForProductStoreDetail(long purchaseReceiveDetailId);
        List<ProductStoreModel> GetProductStoreInformation(long purchaseReceiveDetailId);
    }

    public class ProductStoreService : BaseService<ProductStoreModel, ProductStore>, IProductStoreService
    {
        private readonly IProductStoreRepository _productStoreRepository;

        public ProductStoreService(IProductStoreRepository productStoreRepository)
            : base(productStoreRepository)
        {
            _productStoreRepository = productStoreRepository;
        }

        public int GenerateSerialForProductStoreDetail(long purchaseReceiveDetailId)
        {
            return _productStoreRepository.GenerateSerialForProductStoreDetail(purchaseReceiveDetailId);
        }

        public List<ProductStoreModel> GetProductStoreInformation(long purchaseReceiveDetailId)
        {
            var productStoreList = _productStoreRepository.GetProductStoreInformation(purchaseReceiveDetailId);
            return Mapper.Map<List<ProductStoreModel>>(productStoreList);
        }
    }
}
