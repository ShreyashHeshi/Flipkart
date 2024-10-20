using Microsoft.EntityFrameworkCore;
using System.Data;

using Flipkart.Models;

namespace Flipkart.Repositaries

{
    public class EStoreCollectionContext:DbContext
    {
       public DbSet<Product> Products { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string conString = @"server=localhost;port=3306;user=root; password=Shrey$heshi1745; database=Ecommerce";
            optionsBuilder.UseMySQL(conString);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Title);
                entity.Property(e => e.Description);
                entity.Property(e => e.UnitPrice);
                entity.Property(e => e.Imageurl);
                entity.Property(e => e.Quantity);
            });
            modelBuilder.Entity<Product>().ToTable("Products");
        }
    }
}
