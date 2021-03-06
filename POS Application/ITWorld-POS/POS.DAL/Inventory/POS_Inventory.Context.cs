﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace POS.DAL.Inventory
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class POS_Inventory : DbContext
    {
        public POS_Inventory()
            : base("name=POS_Inventory")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ProductCategory> ProductCategories { get; set; }
        public virtual DbSet<ProductLedger> ProductLedgers { get; set; }
        public virtual DbSet<ProductLedgerDetail> ProductLedgerDetails { get; set; }
        public virtual DbSet<ProductPrice> ProductPrices { get; set; }
        public virtual DbSet<ProductSection> ProductSections { get; set; }
        public virtual DbSet<ProductStore> ProductStores { get; set; }
        public virtual DbSet<ProductUnit> ProductUnits { get; set; }
        public virtual DbSet<PurchaseChallan> PurchaseChallans { get; set; }
        public virtual DbSet<PurchaseChallanDetail> PurchaseChallanDetails { get; set; }
        public virtual DbSet<PurchaseReceive> PurchaseReceives { get; set; }
        public virtual DbSet<PurchaseReceiveDetail> PurchaseReceiveDetails { get; set; }
        public virtual DbSet<PurchaseReturn> PurchaseReturns { get; set; }
        public virtual DbSet<PurchaseReturnDetail> PurchaseReturnDetails { get; set; }
        public virtual DbSet<Supplier> Suppliers { get; set; }
    
        public virtual int USP_GetAllProductStoreInformation()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("USP_GetAllProductStoreInformation");
        }
    
        public virtual ObjectResult<USP_GetAllPurchaseChallan_Result> USP_GetAllPurchaseChallan()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<USP_GetAllPurchaseChallan_Result>("USP_GetAllPurchaseChallan");
        }
    
        public virtual ObjectResult<USP_GetAllPurchaseChallanDetail_Result> USP_GetAllPurchaseChallanDetail(Nullable<long> purchaseChallanId)
        {
            var purchaseChallanIdParameter = purchaseChallanId.HasValue ?
                new ObjectParameter("PurchaseChallanId", purchaseChallanId) :
                new ObjectParameter("PurchaseChallanId", typeof(long));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<USP_GetAllPurchaseChallanDetail_Result>("USP_GetAllPurchaseChallanDetail", purchaseChallanIdParameter);
        }
    
        public virtual ObjectResult<USP_GetAllPurchaseReceive_Result> USP_GetAllPurchaseReceive()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<USP_GetAllPurchaseReceive_Result>("USP_GetAllPurchaseReceive");
        }
    
        public virtual ObjectResult<USP_GetAllPurchaseReceiveDetail_Result> USP_GetAllPurchaseReceiveDetail(Nullable<long> purchaseReceiveId)
        {
            var purchaseReceiveIdParameter = purchaseReceiveId.HasValue ?
                new ObjectParameter("PurchaseReceiveId", purchaseReceiveId) :
                new ObjectParameter("PurchaseReceiveId", typeof(long));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<USP_GetAllPurchaseReceiveDetail_Result>("USP_GetAllPurchaseReceiveDetail", purchaseReceiveIdParameter);
        }
    
        public virtual ObjectResult<USP_GetProductSearchResult_Result> USP_GetProductSearchResult(Nullable<long> productId, string productName, Nullable<long> productCategoryId)
        {
            var productIdParameter = productId.HasValue ?
                new ObjectParameter("ProductId", productId) :
                new ObjectParameter("ProductId", typeof(long));
    
            var productNameParameter = productName != null ?
                new ObjectParameter("ProductName", productName) :
                new ObjectParameter("ProductName", typeof(string));
    
            var productCategoryIdParameter = productCategoryId.HasValue ?
                new ObjectParameter("ProductCategoryId", productCategoryId) :
                new ObjectParameter("ProductCategoryId", typeof(long));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<USP_GetProductSearchResult_Result>("USP_GetProductSearchResult", productIdParameter, productNameParameter, productCategoryIdParameter);
        }
    
        public virtual ObjectResult<USP_GetProductStoreInformation_Result> USP_GetProductStoreInformation(Nullable<long> purchaseReceiveDetailId)
        {
            var purchaseReceiveDetailIdParameter = purchaseReceiveDetailId.HasValue ?
                new ObjectParameter("PurchaseReceiveDetailId", purchaseReceiveDetailId) :
                new ObjectParameter("PurchaseReceiveDetailId", typeof(long));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<USP_GetProductStoreInformation_Result>("USP_GetProductStoreInformation", purchaseReceiveDetailIdParameter);
        }
    }
}
