using System.Collections.Generic;
using AutoMapper;
using POS.BLL.Inventory.Domain;
using POS.DAL.Inventory;
using POS.DAL.Inventory.Repository;
using POS.UTILS.Infrastructure;
using POS.UTILS.Infrastructure.Contract;

namespace POS.BLL.Inventory.Service
{
    public partial interface IPurchaseChallanService : IBaseService<PurchaseChallanModel, PurchaseChallan>
    {
        List<PurchaseChallanModel> GetAllPurchaseChallan();
    }

    public class PurchaseChallanService : BaseService<PurchaseChallanModel, PurchaseChallan>, IPurchaseChallanService
    {
        private readonly IPurchaseChallanRepository _purchaseChallanRepository;

        public PurchaseChallanService(IPurchaseChallanRepository purchaseChallanRepository)
            : base(purchaseChallanRepository)
        {
            _purchaseChallanRepository = purchaseChallanRepository;
        }

        public List<PurchaseChallanModel> GetAllPurchaseChallan()
        {
            var purchaseChallanList = _purchaseChallanRepository.GetAllPurchaseChallan();
            return Mapper.Map<List<PurchaseChallanModel>>(purchaseChallanList);
        }
    }
}
