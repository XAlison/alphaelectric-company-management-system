﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AlphaElectric_DataAccessLayer
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class AlphaElectricEntitiesDB : DbContext
    {
        public AlphaElectricEntitiesDB()
            : base("name=AlphaElectricEntitiesDB")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Designation> Designations { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Inventory> Inventories { get; set; }
        public virtual DbSet<Location> Locations { get; set; }
        public virtual DbSet<PanelShellGradeProtection> PanelShellGradeProtections { get; set; }
        public virtual DbSet<SizeType> SizeTypes { get; set; }
        public virtual DbSet<Type> Types { get; set; }
        public virtual DbSet<Certification> Certifications { get; set; }
        public virtual DbSet<Make> Makes { get; set; }
        public virtual DbSet<PaType> PaTypes { get; set; }
        public virtual DbSet<CustomerOrder> CustomerOrders { get; set; }
        public virtual DbSet<Product_CustomerOrderBT> Product_CustomerOrderBT { get; set; }
        public virtual DbSet<Contact> Contacts { get; set; }
        public virtual DbSet<PurchaseOrder> PurchaseOrders { get; set; }
        public virtual DbSet<Product_PurchaseOrderBT> Product_PurchaseOrderBT { get; set; }
        public virtual DbSet<Project> Projects { get; set; }
        public virtual DbSet<Login> Logins { get; set; }
    }
}
