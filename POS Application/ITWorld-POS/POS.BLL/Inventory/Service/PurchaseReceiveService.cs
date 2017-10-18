using System.Collections.Generic;
using AutoMapper;
using POS.BLL.Inventory.Domain;
using POS.DAL.Inventory;
using POS.DAL.Inventory.Repository;
using POS.UTILS.Infrastructure;
using POS.UTILS.Infrastructure.Contract;

namespace POS.BLL.Inventory.Service
{
    public partial interface IPurchaseReceiveService : IBaseService<PurchaseReceiveModel, PurchaseReceive>
    {
        List<PurchaseReceiveModel> GetAllPurchaseReceive();
    }

    public class PurchaseReceiveService : BaseService<PurchaseReceiveModel, PurchaseReceive>, IPurchaseReceiveService
    {
        private readonly IPurchaseReceiveRepository _purchaseReceiveRepository;

        public PurchaseReceiveService(IPurchaseReceiveRepository purchaseReceiveRepository)
            : base(purchaseReceiveRepository)
        {
            _purchaseReceiveRepository = purchaseReceiveRepository;
        }

        public List<PurchaseReceiveModel> GetAllPurchaseReceive()
        {
            var purchaseReceiveList = _purchaseReceiveRepository.GetAllPurchaseReceive();
            return Mapper.Map<List<PurchaseReceiveModel>>(purchaseReceiveList);
        }
    }
}
