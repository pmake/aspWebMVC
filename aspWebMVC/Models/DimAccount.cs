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
    
    public partial class DimAccount
    {
        public DimAccount()
        {
            this.DimAccount1 = new HashSet<DimAccount>();
            this.FactFinance = new HashSet<FactFinance>();
        }
    
        public int AccountKey { get; set; }
        public Nullable<int> ParentAccountKey { get; set; }
        public Nullable<int> AccountCodeAlternateKey { get; set; }
        public Nullable<int> ParentAccountCodeAlternateKey { get; set; }
        public string AccountDescription { get; set; }
        public string AccountType { get; set; }
        public string Operator { get; set; }
        public string CustomMembers { get; set; }
        public string ValueType { get; set; }
        public string CustomMemberOptions { get; set; }
    
        public virtual ICollection<DimAccount> DimAccount1 { get; set; }
        public virtual DimAccount DimAccount2 { get; set; }
        public virtual ICollection<FactFinance> FactFinance { get; set; }
    }
}