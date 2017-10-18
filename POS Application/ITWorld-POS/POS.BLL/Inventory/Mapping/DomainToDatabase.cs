using AutoMapper;
using POS.BLL.Inventory.Domain;
using POS.DAL.Inventory;

namespace POS.BLL.Inventory.Mapping
{
    public class DomainToDatabase : Profile
    {
        protected override void Configure()
        {
            //.ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id));
            CreateMap<ProductCategoryModel, ProductCategory>();
            CreateMap<ProductSectionModel, ProductSection>();
            CreateMap<ProductUnitModel, ProductUnit>();
            CreateMap<SupplierModel, Supplier>();
            CreateMap<ProductModel, Product>();
            CreateMap<ProductStoreModel, ProductStore>();
            CreateMap<ProductPriceModel, ProductPrice>();
            CreateMap<PurchaseChallanModel, PurchaseChallan>();
            CreateMap<PurchaseChallanDetailModel, PurchaseChallanDetail>();
            CreateMap<PurchaseReceiveModel, PurchaseReceive>();
            CreateMap<PurchaseReceiveDetailModel, PurchaseReceiveDetail>();
            CreateMap<PurchaseReturnModel, PurchaseReturn>();
            CreateMap<PurchaseReturnDetailModel, PurchaseReturnDetail>();
        }
    }
}
