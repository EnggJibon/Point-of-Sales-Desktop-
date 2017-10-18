using System.Collections.Generic;
using AutoMapper;
using POS.BLL.Inventory.Domain;
using POS.DAL.Inventory;
using POS.DAL.Inventory.Repository;
using POS.UTILS.Infrastructure;
using POS.UTILS.Infrastructure.Contract;

namespace POS.BLL.Inventory.Service
{
    public partial interface IPurchaseReturnDetailService : IBaseService<PurchaseReturnDetailModel, PurchaseReturnDetail>
    {
        //List<PurchaseReturnDetailModel> GetAllPurchaseReturnDetailInformation();
    }

    public class PurchaseReturnDetailService : BaseService<PurchaseReturnDetailModel, PurchaseReturnDetail>, IPurchaseReturnDetailService
    {
        private readonly IPurchaseReturnDetailRepository _purchaseReturnDetailRepository;

        public PurchaseReturnDetailService(IPurchaseReturnDetailRepository purchaseReturnDetailRepository)
            : base(purchaseReturnDetailRepository)
        {
            _purchaseReturnDetailRepository = purchaseReturnDetailRepository;
        }

        //public List<PurchaseReturnDetailModel> GetAllPurchaseReturnDetailInformation()
        //{
        //    var PurchaseReturnDetails = _PurchaseReturnDetailRepository.GetAllPurchaseReturnDetailInformation();
        //    return Mapper.Map<List<PurchaseReturnDetailModel>>(PurchaseReturnDetails);
        //}
    }
}
