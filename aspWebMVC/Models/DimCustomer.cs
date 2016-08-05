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
    
    public partial class DimCustomer
    {
        public DimCustomer()
        {
            this.FactInternetSales = new HashSet<FactInternetSales>();
            this.FactSurveyResponse = new HashSet<FactSurveyResponse>();
        }
    
        public int CustomerKey { get; set; }
        public Nullable<int> GeographyKey { get; set; }
        public string CustomerAlternateKey { get; set; }
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public Nullable<bool> NameStyle { get; set; }
        public Nullable<System.DateTime> BirthDate { get; set; }
        public string MaritalStatus { get; set; }
        public string Suffix { get; set; }
        public string Gender { get; set; }
        public string EmailAddress { get; set; }
        public Nullable<decimal> YearlyIncome { get; set; }
        public Nullable<byte> TotalChildren { get; set; }
        public Nullable<byte> NumberChildrenAtHome { get; set; }
        public string EnglishEducation { get; set; }
        public string SpanishEducation { get; set; }
        public string FrenchEducation { get; set; }
        public string EnglishOccupation { get; set; }
        public string SpanishOccupation { get; set; }
        public string FrenchOccupation { get; set; }
        public string HouseOwnerFlag { get; set; }
        public Nullable<byte> NumberCarsOwned { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string Phone { get; set; }
        public Nullable<System.DateTime> DateFirstPurchase { get; set; }
        public string CommuteDistance { get; set; }
    
        public virtual DimGeography DimGeography { get; set; }
        public virtual ICollection<FactInternetSales> FactInternetSales { get; set; }
        public virtual ICollection<FactSurveyResponse> FactSurveyResponse { get; set; }
    }
}