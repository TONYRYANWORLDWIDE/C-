﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebService.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class TRBillsEntities : DbContext
    {
        public TRBillsEntities()
            : base("name=TRBillsEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<BringHomePay> BringHomePays { get; set; }
        public virtual DbSet<KeyBalance> KeyBalances { get; set; }
        public virtual DbSet<MonthlyBill> MonthlyBills { get; set; }
        public virtual DbSet<WeeklyBill> WeeklyBills { get; set; }
    }
}
