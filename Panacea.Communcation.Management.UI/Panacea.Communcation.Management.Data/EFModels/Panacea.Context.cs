﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Panacea.Communcation.Management.Business.EFModels
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class PCMEntities : DbContext
    {
        public PCMEntities()
            : base("name=PCMEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AspNetRoles> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaims> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogins> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUsers> AspNetUsers { get; set; }
        public virtual DbSet<RefStatus> RefStatus { get; set; }
        public virtual DbSet<Contacts> Contacts { get; set; }
        public virtual DbSet<Organisations> Organisations { get; set; }
        public virtual DbSet<Groups> Groups { get; set; }
        public virtual DbSet<Enquiry> Enquiry { get; set; }
        public virtual DbSet<RefEnquiryStatus> RefEnquiryStatus { get; set; }
        public virtual DbSet<RefEnquiryType> RefEnquiryType { get; set; }
        public virtual DbSet<RefOutcome> RefOutcome { get; set; }
        public virtual DbSet<RefResponseMethod> RefResponseMethod { get; set; }
        public virtual DbSet<Team> Team { get; set; }
    }
}
