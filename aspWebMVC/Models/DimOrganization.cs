//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class DimOrganization
    {
        public DimOrganization()
        {
            this.DimOrganization1 = new HashSet<DimOrganization>();
            this.FactFinance = new HashSet<FactFinance>();
        }
    
        public int OrganizationKey { get; set; }
        public Nullable<int> ParentOrganizationKey { get; set; }
        public string PercentageOfOwnership { get; set; }
        public string OrganizationName { get; set; }
        public Nullable<int> CurrencyKey { get; set; }
    
        public virtual DimCurrency DimCurrency { get; set; }
        public virtual ICollection<DimOrganization> DimOrganization1 { get; set; }
        public virtual DimOrganization DimOrganization2 { get; set; }
        public virtual ICollection<FactFinance> FactFinance { get; set; }
    }
}
