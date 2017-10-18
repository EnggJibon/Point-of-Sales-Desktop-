using POS.UTILS.Infrastructure;

namespace POS.BLL.Sales.Domain
{
    public class SaleReturnReceiveDetailModel : BaseDomainModel<SaleReturnReceiveDetailModel>
    {
        public long SaleReturnId { get; set; }
        public long ReferenceSaleId { get; set; }
        public long ProductId { get; set; }
        public decimal ProductUnitPrice { get; set; }
        public int ProductQuantity { get; set; }
        public decimal ProductTotalPrice { get; set; }
        public string Description { get; set; }
    }
}
