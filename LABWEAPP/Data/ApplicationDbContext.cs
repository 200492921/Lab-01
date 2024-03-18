// Inside ApplicationDbContext.cs

using Microsoft.EntityFrameworkCore;
using LabWebApp.Models;
public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<Product> Products { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Seed data for the Product entity
        modelBuilder.Entity<Product>().HasData(
            new Product { Id = 1, Name = "Product 1", Price = 19.99m, Description = "Description for Product 1" },
            new Product { Id = 2, Name = "Product 2", Price = 29.99m, Description = "Description for Product 2" },
            new Product { Id = 3, Name = "Product 3", Price = 39.99m, Description = "Description for Product 3" }
            // Add more seed data as needed
        );
    }
}
