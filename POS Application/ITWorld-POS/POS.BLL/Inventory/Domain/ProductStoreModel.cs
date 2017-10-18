using System;
using POS.UTILS.Infrastructure;

namespace POS.BLL.Inventory.Domain
{
    public class ProductStoreModel : BaseDomainModel<ProductStoreModel>
    {
        public long PurchaseReceiveDetailId { get; set; }
        public long ProductId { get; set; }
        public int Serial { get; set; }
        public long? ProductUnitId { get; set; }
        public string ProductUnitName { get; set; }
        public long? ProductSectionId { get; set; }
        public string ProductSectionName { get; set; }
        public int ProductQuantity { get; set; }
        public string ProductSizeCode { get; set; }
        public string ProductSizeNumber { get; set; }
        public string ProductSizeAge { get; set; }
        public string ProductColor { get; set; }
        public string ProductStyle { get; set; }
        public string Description { get; set; }

        //public long ProductCategoryId { get; set; }
        //public string ProductCategoryName { get; set; }
        //public long ProductSupplierId { get; set; }
        //public string ProductSupplierName { get; set; }
        //public string ProductName { get; set; }
    }
}
