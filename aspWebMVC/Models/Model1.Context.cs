﻿//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace aspWebMVC.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class AdventureWorksDW2012Entities : DbContext
    {
        public AdventureWorksDW2012Entities()
            : base("name=AdventureWorksDW2012Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<DimAccount> DimAccount { get; set; }
        public virtual DbSet<DimCurrency> DimCurrency { get; set; }
        public virtual DbSet<DimCustomer> DimCustomer { get; set; }
        public virtual DbSet<DimDate> DimDate { get; set; }
        public virtual DbSet<DimDepartmentGroup> DimDepartmentGroup { get; set; }
        public virtual DbSet<DimEmployee> DimEmployee { get; set; }
        public virtual DbSet<DimGeography> DimGeography { get; set; }
        public virtual DbSet<DimOrganization> DimOrganization { get; set; }
        public virtual DbSet<DimProduct> DimProduct { get; set; }
        public virtual DbSet<DimProductCategory> DimProductCategory { get; set; }
        public virtual DbSet<DimProductSubcategory> DimProductSubcategory { get; set; }
        public virtual DbSet<DimPromotion> DimPromotion { get; set; }
        public virtual DbSet<DimReseller> DimReseller { get; set; }
        public virtual DbSet<DimSalesReason> DimSalesReason { get; set; }
        public virtual DbSet<DimSalesTerritory> DimSalesTerritory { get; set; }
        public virtual DbSet<DimScenario> DimScenario { get; set; }
        public virtual DbSet<FactAdditionalInternationalProductDescription> FactAdditionalInternationalProductDescription { get; set; }
        public virtual DbSet<FactCallCenter> FactCallCenter { get; set; }
        public virtual DbSet<FactCurrencyRate> FactCurrencyRate { get; set; }
        public virtual DbSet<FactInternetSales> FactInternetSales { get; set; }
        public virtual DbSet<FactProductInventory> FactProductInventory { get; set; }
        public virtual DbSet<FactResellerSales> FactResellerSales { get; set; }
        public virtual DbSet<FactSalesQuota> FactSalesQuota { get; set; }
        public virtual DbSet<FactSurveyResponse> FactSurveyResponse { get; set; }
        public virtual DbSet<ProspectiveBuyer> ProspectiveBuyer { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<DatabaseLog> DatabaseLog { get; set; }
        public virtual DbSet<FactFinance> FactFinance { get; set; }
    }
}
