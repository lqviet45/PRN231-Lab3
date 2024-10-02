using Bogus;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Repository.entities;

namespace Repository;

public class MyDbContext : DbContext
{
    public MyDbContext()
    {
    }

    public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

        IConfiguration configuration = builder.Build();
        optionsBuilder.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
    }
    
    public virtual DbSet<Product> Products { get; set; }
    public virtual DbSet<Category> Categories { get; set; }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .Entity<Category>()
            .HasData(
                new Category { Id = 1, CategoryName = "Beverages" },
                new Category { Id = 2, CategoryName = "Condiments" },
                new Category { Id = 3, CategoryName = "Confections" },
                new Category { Id = 4, CategoryName = "Dairy Products" },
                new Category { Id = 5, CategoryName = "Grains/Cereals" },
                new Category { Id = 6, CategoryName = "Meat/Poultry" },
                new Category { Id = 7, CategoryName = "Produce" },
                new Category { Id = 8, CategoryName = "Seafood" }
            );
        
        // Use Bogus to generate 100 fake products
        var faker = new Faker<Product>()
            .RuleFor(p => p.Id, f => f.IndexFaker + 1) // Ids starting from 1
            .RuleFor(p => p.ProductName, f => f.Commerce.ProductName())
            .RuleFor(p => p.CategoryId, f => f.Random.Int(1, 8)) // Random category between 1 and 8
            .RuleFor(p => p.UnitsInStock, f => f.Random.Int(0, 100)) // Random stock between 0 and 100
            .RuleFor(p => p.UnitPrice, f => f.Random.Decimal(1, 100)); // Random price between $1 and $100

        // Generate 100 products
        var products = faker.Generate(100);

        // Seed generated products
        modelBuilder.Entity<Product>().HasData(products);
    }
}