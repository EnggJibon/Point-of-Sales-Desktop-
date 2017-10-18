using Ninject.Modules;
using POS.DAL.Inventory.Repository;

namespace POS.BLL.Inventory.IOC
{
    public partial class InventoryRepositoryModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IProductCategoryRepository>().To<ProductCategoryRepository>();
            Bind<IProductSectionRepository>().To<ProductSectionRepository>();
            Bind<IProductUnitRepository>().To<ProductUnitRepository>();
            Bind<ISupplierRepository>().To<SupplierRepository>();
            Bind<IProductRepository>().To<ProductRepository>();
            Bind<IProductStoreRepository>().To<ProductStoreRepository>();
            Bind<IProductPriceRepository>().To<ProductPriceRepository>();
            Bind<IPurchaseChallanRepository>().To<PurchaseChallanRepository>();
            Bind<IPurchaseChallanDetailRepository>().To<PurchaseChallanDetailRepository>();
            Bind<IPurchaseReceiveRepository>().To<PurchaseReceiveRepository>();
            Bind<IPurchaseReceiveDetailRepository>().To<PurchaseReceiveDetailRepository>();
            Bind<IPurchaseReturnRepository>().To<PurchaseReturnRepository>();
            Bind<IPurchaseReturnDetailRepository>().To<PurchaseReturnDetailRepository>();
        }
    }
}

