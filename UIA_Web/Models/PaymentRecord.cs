//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UIA_Web.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class PaymentRecord
    {
        public string PurchaseId { get; set; }
        public string UserId { get; set; }
        public string CardNumber { get; set; }
        public string CCV { get; set; }
        public string ExpiryDate { get; set; }
        public int TotalPrice { get; set; }
        public System.DateTime PurchaseDate { get; set; }
        public string CardType { get; set; }
        public string CardHolderName { get; set; }
    
        public virtual AspNetUser AspNetUser { get; set; }
    }
}
