using DockerDemo.API.Entities;
using Microsoft.EntityFrameworkCore;

namespace DockerDemo.API.Database;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions options)
        : base(options)
    {

    }

    public DbSet<Product> Products { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        var productBuilder = modelBuilder.Entity<Product>();

        productBuilder.ToTable("Products");

        productBuilder.HasKey(product => product.Id);

        productBuilder.Property(product => product.Name)
            .IsRequired()
            .HasMaxLength(200);

        productBuilder.Property(product => product.Price)
            .IsRequired();

        productBuilder.Property(product => product.Quantity)
            .IsRequired();
    }
}
