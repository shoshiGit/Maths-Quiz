﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BLL
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Entities1 : DbContext
    {
        public Entities1()
            : base("name=Entities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Multiple_Choice_A> Multiple_Choice_A { get; set; }
        public virtual DbSet<Multiple_Choice_Q> Multiple_Choice_Q { get; set; }
        public virtual DbSet<Question_Ans1> Question_Ans1 { get; set; }
        public virtual DbSet<Students> Students { get; set; }
        public virtual DbSet<MyHistory> MyHistory { get; set; }
    }
}