using AutoMapper;
using POS.BLL.Inventory.Domain;
using POS.DAL.Inventory;

namespace POS.BLL.Inventory.Mapping
{
    public class DatabaseToDomain : Profile
    {
        protected override void Configure()
        {
            //.ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id));
            CreateMap<ProductCategory, ProductCategoryModel>();
            CreateMap<ProductSection, ProductSectionModel>();
            CreateMap<ProductUnit, ProductUnitModel>();
            CreateMap<Supplier, SupplierModel>();
            CreateMap<Product, ProductModel>();
            CreateMap<ProductStore, ProductStoreModel>();
            CreateMap<ProductPrice, ProductPriceModel>();
            CreateMap<PurchaseChallan, PurchaseChallanModel>();
            CreateMap<PurchaseChallanDetail, PurchaseChallanDetailModel>();
            CreateMap<PurchaseReceive, PurchaseReceiveModel>();
            CreateMap<PurchaseReceiveDetail, PurchaseReceiveDetailModel>();
            CreateMap<PurchaseReturn, PurchaseReturnModel>();
            CreateMap<PurchaseReturnDetail, PurchaseReturnDetailModel>();

            CreateMap<USP_GetAllPurchaseChallan_Result, PurchaseChallanModel>();
            CreateMap<USP_GetAllPurchaseChallanDetail_Result, PurchaseChallanDetailModel>();
            CreateMap<USP_GetAllPurchaseReceive_Result, PurchaseReceiveModel>();
            CreateMap<USP_GetAllPurchaseReceiveDetail_Result, PurchaseReceiveDetailModel>();
            CreateMap<USP_GetProductStoreInformation_Result, ProductStoreModel>();
            CreateMap<USP_GetProductSearchResult_Result, ProductSearchInformation>();
        }
    }
}
