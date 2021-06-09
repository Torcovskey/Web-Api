using Data.Entity;
using Data.Entity.IntermediateEntity;
using Data.Entity.IntermediateEntity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data
{
    public class ShopContext : DbContext
    {
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Basket> Baskets { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<BasketProduct> BasketProducts { get; set; }
        public DbSet<OrderProducts> OrderProducts { get; set; }
        public DbSet<Company> Companies { get; set; }

        public ShopContext(DbContextOptions options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Basket - product

            modelBuilder.Entity<BasketProduct>()
                .HasKey(t => new { t.BasketId, t.ProductId });

            modelBuilder.Entity<BasketProduct>()
                .HasOne(sc => sc.Basket)
                .WithMany(s => s.BasketProducts)
                .HasForeignKey(sc => sc.BasketId);

            modelBuilder.Entity<BasketProduct>()
                .HasOne(sc => sc.Product)
                .WithMany(c => c.BasketProducts)
                .HasForeignKey(sc => sc.ProductId);

            // Order - product

            modelBuilder.Entity<OrderProducts>()
                .HasKey(t => new { t.OrderId, t.ProductId });

            modelBuilder.Entity<OrderProducts>()
                .HasOne(sc => sc.Order)
                .WithMany(a => a.OrderProducts)
                .HasForeignKey(sc => sc.OrderId);

            modelBuilder.Entity<OrderProducts>()
                .HasOne(sc => sc.Product)
                .WithMany(c => c.OrderProducts)
                .HasForeignKey(sc => sc.ProductId);
        }
    }
}
