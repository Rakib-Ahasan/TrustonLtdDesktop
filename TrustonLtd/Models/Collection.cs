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
    
    public partial class Collection
    {
        public int CollectionId { get; set; }
        public System.DateTime DateTime { get; set; }
        public int WorkerId { get; set; }
        public int TotalDistributed { get; set; }
        public int ProductId { get; set; }
        public int Piece { get; set; }
        public int Return { get; set; }
        public int Remaining { get; set; }
        public int TotalCollected { get; set; }
        public int PayableDeposit { get; set; }
    
        public virtual Product Product { get; set; }
        public virtual Worker Worker { get; set; }
    }
}
