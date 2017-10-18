using POS.UTILS.Infrastructure;

namespace POS.BLL.Inventory.Domain
{
    public class PurchaseReturnModel : BaseDomainModel<PurchaseReturnModel>
    {
        public string ReturnNumber { get; set; }
        public System.DateTime ReturnDate { get; set; }
        public string ReturnBy { get; set; }
        public long PurchaseReceiveId { get; set; }
        public string ReceiveNumber { get; set; }
        public long SupplierId { get; set; }
        public string Description { get; set; }
    }
}
