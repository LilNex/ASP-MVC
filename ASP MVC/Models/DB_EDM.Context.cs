﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP_MVC.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class aspnetzeroEntities : DbContext
    {
        public aspnetzeroEntities()
            : base("name=aspnetzeroEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AbpPermission> AbpPermissions { get; set; }
        public virtual DbSet<AbpUserLogin> AbpUserLogins { get; set; }
        public virtual DbSet<AbpUser> AbpUsers { get; set; }
    }
}