using System;
using POS.UTILS.Infrastructure;

namespace POS.BLL.Inventory.Domain
{
    public class PurchaseChallanDetailModel : BaseDomainModel<PurchaseChallanDetailModel>
    {
        public long PurchaseChallanId { get; set; }
        public string ChallanNumber { get; set; }
        public long ProductId { get; set; }
        public string ProductName { get; set; }
        public long? ProductCategoryId { get; set; }
        public string ProductCategoryName { get; set; }
        public decimal ProductUnitPrice { get; set; }
        public int ProductQuantity { get; set; }
        public decimal TotalPrice { get; set; }
        public string Description { get; set; }
    }
}
