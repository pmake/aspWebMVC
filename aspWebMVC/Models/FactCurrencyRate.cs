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
    
    public partial class FactCurrencyRate
    {
        public int CurrencyKey { get; set; }
        public int DateKey { get; set; }
        public double AverageRate { get; set; }
        public double EndOfDayRate { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
    
        public virtual DimCurrency DimCurrency { get; set; }
        public virtual DimDate DimDate { get; set; }
    }
}
