//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TrustonLtd.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Sale
    {
        public int SalesId { get; set; }
        public int CustomerId { get; set; }
        public int PreviousDue { get; set; }
        public string SalesBy { get; set; }
        public int ProductId { get; set; }
        public int Piece { get; set; }
        public int Rate { get; set; }
        public int NetTotalBill { get; set; }
        public int ReturnProductId { get; set; }
        public int ReturnRate { get; set; }
        public int ReturnPiece { get; set; }
        public int TotalReturnPrice { get; set; }
        public int TotalBill { get; set; }
        public int LessPrice { get; set; }
        public int Pay { get; set; }
        public int Due { get; set; }
        public System.DateTime DateTime { get; set; }
    
        public virtual Customer Customer { get; set; }
        public virtual Product Product { get; set; }
    }
}