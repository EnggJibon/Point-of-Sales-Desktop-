using POS.UTILS.Infrastructure;

namespace POS.BLL.Inventory.Domain
{
    public class SupplierModel : BaseDomainModel<SupplierModel>
    {
        public string SupplierCode { get; set; }
        public string SupplierName { get; set; }
        public string Address { get; set; }
        public string OwnerName { get; set; }
        public string ContactNumber { get; set; }
        public string Email { get; set; }
        public string NID { get; set; }
        public string BankAccountNumber { get; set; }
        public string TIN { get; set; }
        public string Description { get; set; }
    }
}
