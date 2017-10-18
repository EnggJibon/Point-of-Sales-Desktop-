using System.Collections.Generic;
using AutoMapper;
using POS.BLL.Inventory.Domain;
using POS.DAL.Inventory;
using POS.DAL.Inventory.Repository;
using POS.UTILS.Infrastructure;
using POS.UTILS.Infrastructure.Contract;

namespace POS.BLL.Inventory.Service
{
    public partial interface IPurchaseReceiveDetailService : IBaseService<PurchaseReceiveDetailModel, PurchaseReceiveDetail>
    {
        List<PurchaseReceiveDetailModel> GetAllPurchaseReceiveDetail(long purchaseReceiveId);
    }

    public class PurchaseReceiveDetailService : BaseService<PurchaseReceiveDetailModel, PurchaseReceiveDetail>, IPurchaseReceiveDetailService
    {
        private readonly IPurchaseReceiveDetailRepository _purchaseReceiveDetailRepository;

        public PurchaseReceiveDetailService(IPurchaseReceiveDetailRepository purchaseReceiveDetailRepository)
            : base(purchaseReceiveDetailRepository)
        {
            _purchaseReceiveDetailRepository = purchaseReceiveDetailRepository;
        }

        public List<PurchaseReceiveDetailModel> GetAllPurchaseReceiveDetail(long purchaseReceiveId)
        {
            var purchaseReceiveDetailList = _purchaseReceiveDetailRepository.GetAllPurchaseReceiveDetail(purchaseReceiveId);
            return Mapper.Map<List<PurchaseReceiveDetailModel>>(purchaseReceiveDetailList);
        }
    }
}
