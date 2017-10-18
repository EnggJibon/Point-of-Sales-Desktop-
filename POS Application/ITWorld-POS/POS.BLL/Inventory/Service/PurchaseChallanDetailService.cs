using System.Collections.Generic;
using AutoMapper;
using POS.BLL.Inventory.Domain;
using POS.DAL.Inventory;
using POS.DAL.Inventory.Repository;
using POS.UTILS.Infrastructure;
using POS.UTILS.Infrastructure.Contract;

namespace POS.BLL.Inventory.Service
{
    public partial interface IPurchaseChallanDetailService : IBaseService<PurchaseChallanDetailModel, PurchaseChallanDetail>
    {
        List<PurchaseChallanDetailModel> GetAllPurchaseChallanDetail(long purchaseChallanId);
    }

    public class PurchaseChallanDetailService : BaseService<PurchaseChallanDetailModel, PurchaseChallanDetail>, IPurchaseChallanDetailService
    {
        private readonly IPurchaseChallanDetailRepository _purchaseChallanDetailRepository;

        public PurchaseChallanDetailService(IPurchaseChallanDetailRepository purchaseChallanDetailRepository)
            : base(purchaseChallanDetailRepository)
        {
            _purchaseChallanDetailRepository = purchaseChallanDetailRepository;
        }

        public List<PurchaseChallanDetailModel> GetAllPurchaseChallanDetail(long purchaseChallanId)
        {
            var purchaseChallanDetailList = _purchaseChallanDetailRepository.GetAllPurchaseChallanDetail(purchaseChallanId);
            return Mapper.Map<List<PurchaseChallanDetailModel>>(purchaseChallanDetailList);
        }
    }
}
