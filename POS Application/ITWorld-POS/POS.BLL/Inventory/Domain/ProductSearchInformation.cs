using System;

namespace POS.BLL.Inventory.Domain
{
    public class ProductSearchInformation
    {
        public long ProductId { get; set; }
        public string ProductName { get; set; }
        public long ProductCategoryId { get; set; }
        public string ProductCategoryName { get; set; }
        public long? PurchaseReceiveId { get; set; }
        public DateTime? ReceiveDate { get; set; }
        public string ReceiveNumber { get; set; }
        public long? PurchaseReceiveDetailId { get; set; }
        public decimal ProductUnitPrice { get; set; }
        public decimal DiscountInPercentage { get; set; }
        public int ProductQuantity { get; set; }
    }
}
