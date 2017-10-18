using Ninject.Modules;
using POS.BLL.Inventory.Service;

namespace POS.BLL.Inventory.IOC 
{
    public partial class InventoryServiceModule : NinjectModule
	{
		public override void Load()
        {
            Bind<IProductCategoryService>().To<ProductCategoryService>();
            Bind<IProductSectionService>().To<ProductSectionService>();
            Bind<ProductUnitService>().To<ProductUnitService>();
            Bind<ISupplierService>().To<SupplierService>();
            Bind<IProductService>().To<ProductService>();
            Bind<IProductStoreService>().To<ProductStoreService>();
            Bind<IProductPriceService>().To<ProductPriceService>();
            Bind<IPurchaseChallanService>().To<PurchaseChallanService>();
            Bind<IPurchaseChallanDetailService>().To<PurchaseChallanDetailService>();
            Bind<IPurchaseReceiveService>().To<PurchaseReceiveService>();
            Bind<IPurchaseReceiveDetailService>().To<PurchaseReceiveDetailService>();
            Bind<IPurchaseReturnService>().To<PurchaseReturnService>();
            Bind<IPurchaseReturnDetailService>().To<PurchaseReturnDetailService>();
		}
	}
}

