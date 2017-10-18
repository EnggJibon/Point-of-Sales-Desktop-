using POS.UTILS.Infrastructure;

namespace POS.BLL.Sales.Domain
{
    public class SaleDetailModel : BaseDomainModel<SaleDetailModel>
    {
        public long SaleId { get; set; }
        public long ProductId { get; set; }
        public string ProductName { get; set; }
        public int ProductQuantity { get; set; }
        public decimal ProductUnitPrice { get; set; }
        public decimal ProductDiscountInPercentage { get; set; }
        public decimal ProductDiscountAmount { get; set; }
        public decimal ProductTotalPrice { get; set; }
        public string Description { get; set; }
    }
}
