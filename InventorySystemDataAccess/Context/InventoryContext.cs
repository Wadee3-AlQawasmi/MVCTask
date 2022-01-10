
using InventorySystemDataAccess.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;


namespace InventorySystemDataAccess.Context
{
   public class InventoryContext:DbContext
    {
        public DbSet<AttributeValue> AttributeValue { set; get; }
        public DbSet<Brand> Brand { set; get; }    
        public DbSet<Attributes> Attribute { set; get; }
        public DbSet<Category> Category { set; get; }
        public DbSet<Company> Company { set; get; }
        public DbSet<Country> Country { set; get; }
        public DbSet<Currency> Currency { set; get; }   
        public DbSet<Order> Order { set; get; }
        public DbSet<Product> Product { set; get; }
        public DbSet<Store> Store { set; get; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("data source= localhost; initial catalog = InventorySystem ; Integrated Security = true");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
