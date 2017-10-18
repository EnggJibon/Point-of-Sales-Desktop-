using POS.UTILS.Infrastructure;

namespace POS.BLL.Sales.Domain
{
    public class SalePaymentModel : BaseDomainModel<SalePaymentModel>
    {
        public long SaleId { get; set; }
        public decimal NetAmount { get; set; }
        public decimal ReceivedCashAmount { get; set; }
        public decimal ReceivedCardAmount { get; set; }
        public decimal ReceivedSaleReturnAmount { get; set; }
        public long? ReceivedSaleReturnId { get; set; }
        public decimal DiscountInPercentageForCard { get; set; }
        public decimal DiscountAmountForCard { get; set; }
        public long? BankIdForCard { get; set; }
        public string CardType { get; set; }
        public string CardNo { get; set; }
        public string Description { get; set; }
    }
}
