using Data.Entity;
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

        public ShopContext(DbContextOptions options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
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
        }
    }
}
