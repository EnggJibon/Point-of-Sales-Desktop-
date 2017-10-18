using System.Collections.Generic;
using AutoMapper;
using POS.BLL.Inventory.Domain;
using POS.DAL.Inventory;
using POS.DAL.Inventory.Repository;
using POS.UTILS.Infrastructure;
using POS.UTILS.Infrastructure.Contract;

namespace POS.BLL.Inventory.Service
{
    public partial interface IPurchaseReturnService : IBaseService<PurchaseReturnModel, PurchaseReturn>
    {
        //List<PurchaseReturnModel> GetAllPurchaseReturnInformation();
    }

    public class PurchaseReturnService : BaseService<PurchaseReturnModel, PurchaseReturn>, IPurchaseReturnService
    {
        private readonly IPurchaseReturnRepository _purchaseReturnRepository;

        public PurchaseReturnService(IPurchaseReturnRepository purchaseReturnRepository)
            : base(purchaseReturnRepository)
        {
            _purchaseReturnRepository = purchaseReturnRepository;
        }

        //public List<PurchaseReturnModel> GetAllPurchaseReturnInformation()
        //{
        //    var PurchaseReturns = _PurchaseReturnRepository.GetAllPurchaseReturnInformation();
        //    return Mapper.Map<List<PurchaseReturnModel>>(PurchaseReturns);
        //}
    }
}
