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
    
    public partial class BuyEmbroideryOrnaOrThreePiece
    {
        public int BuyEmbroideryOrnaOrThreePieceId { get; set; }
        public System.DateTime DateTime { get; set; }
        public int ProductId { get; set; }
        public int Piece { get; set; }
        public int TotalAmount { get; set; }
    
        public virtual Product Product { get; set; }
    }
}
