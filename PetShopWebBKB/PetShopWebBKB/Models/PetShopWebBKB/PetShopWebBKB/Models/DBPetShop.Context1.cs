﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PetShopWebBKB.Models.PetShopWebBKB.PetShopWebBKB.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class PetShopEntities : DbContext
    {
        public PetShopEntities()
            : base("name=PetShopEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AdminUser> AdminUsers { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Fur> Furs { get; set; }
        public virtual DbSet<Menu> Menus { get; set; }
        public virtual DbSet<OrderDetail> OrderDetails { get; set; }
        public virtual DbSet<OrderPro> OrderProes { get; set; }
        public virtual DbSet<Origin> Origins { get; set; }
        public virtual DbSet<Popular> Populars { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Size> Sizes { get; set; }
    }
}
