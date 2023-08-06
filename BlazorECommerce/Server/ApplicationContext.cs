using BlazorECommerce.Shared;
using Microsoft.EntityFrameworkCore;

namespace BlazorECommerce.Server
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>()
                .HasData(new Product
                {
                    Name = "Painting",
                    Description = "",
                    Price = 1000
                },
                new Product
                {
                    Name = "Embroidery",
                    Description = "",
                    Price = 2000
                });
        }
        public DbSet<Product> Products { get; set; }
    }
}
