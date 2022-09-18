using DataBaseNet.Data.Entittes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseNet.Data
{
    public class MyDataContext:DbContext
    {
        
        public MyDataContext()
        {
            this.Database.Migrate();   //avtoMigration
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Basket> Baskets { get; set; }
        public DbSet<OrderStatus> OrderStatuses { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                " Server = SergiyDatabase.mssql.somee.com;" +
                " DataBase = SergiyDatabase;" +
                " User Id = SOJER22_SQLLogin_1;" +
                " Password = ww4b5fv8hf;");
        }

        protected override void OnModelCreating (ModelBuilder builder)
        {
            builder.Entity<Basket>(basket=>
            {
                basket.HasKey(b => new { b.UserId, b.ProductId });
            });
        }
    }
}
 