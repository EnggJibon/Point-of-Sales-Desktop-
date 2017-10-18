using POS.UTILS.Infrastructure;

namespace POS.BLL.Sales.Domain
{
    public class SaleReturnReceiveModel : BaseDomainModel<SaleReturnReceiveModel>
    {
        public System.DateTime SaleReturnDate { get; set; }
        public long SaleId { get; set; }
        public System.DateTime SaleDate { get; set; }
        public long SaleInvoiceId { get; set; }
        public decimal TotalSalePrice { get; set; }
        public decimal VATInPercentage { get; set; }
        public decimal VATInAmount { get; set; }
        public decimal NetAmount { get; set; }
        public string SaleReturnBy { get; set; }
        public string Description { get; set; }
    }
}
