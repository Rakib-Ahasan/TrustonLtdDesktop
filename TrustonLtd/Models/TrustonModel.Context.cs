﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using TrustonLtd.Models;

namespace TrustonLtd
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class TrustonEntities : DbContext
    {
        public TrustonEntities()
            : base("name=TrustonEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<BuyEmbroideryOrnaOrThreePiece> BuyEmbroideryOrnaOrThreePieces { get; set; }
        public virtual DbSet<BuyPrideOrYearn> BuyPrideOrYearns { get; set; }
        public virtual DbSet<Collection> Collections { get; set; }
        public virtual DbSet<Cost> Costs { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<CustomerPayment> CustomerPayments { get; set; }
        public virtual DbSet<Distribution> Distributions { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Sale> Sales { get; set; }
        public virtual DbSet<StockIn> StockIns { get; set; }
        public virtual DbSet<Worker> Workers { get; set; }
        public virtual DbSet<WorkerPayment> WorkerPayments { get; set; }
    }
}
