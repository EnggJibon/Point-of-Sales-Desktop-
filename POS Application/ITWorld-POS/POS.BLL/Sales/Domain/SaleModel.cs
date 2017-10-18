using System.Collections.Generic;
using POS.UTILS.Infrastructure;

namespace POS.BLL.Sales.Domain
{
    public class SaleModel : BaseDomainModel<SaleModel>
    {
        public System.DateTime SaleDate { get; set; }
        public long SaleInvoiceId { get; set; }
        public System.DateTime SaleInvoiceDate { get; set; }
        public decimal TotalSalePrice { get; set; }
        public decimal DiscountInPercentage { get; set; }
        public decimal DiscountAmount { get; set; }
        public decimal VATInPercentage { get; set; }
        public decimal VATAmount { get; set; }
        public decimal ServiceCharge { get; set; }
        public decimal NetAmount { get; set; }
        public string SaleBy { get; set; }
        public string Description { get; set; }

        public IEnumerable<SaleDetailModel> SaleDetailList { get; set; }
        public SalePaymentModel SalePayment { get; set; }
    }
}
