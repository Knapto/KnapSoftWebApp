using KnapSoft.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace KnapSoft.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }
    public DbSet<Product> Products { get; set; }
    public DbSet<KnapSoft.Models.Solution> Solutions { get; set; }
    public DbSet<SolutionProduct> SolutionProducts { get; set; }
    public DbSet<BlogPost> BlogPosts { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.Entity<SolutionProduct>()
            .HasKey(sp => new { sp.SolutionId, sp.ProductId });

        builder.Entity<SolutionProduct>()
            .HasOne(sp => sp.Solution)
            .WithMany(s => s.SolutionProducts)
            .HasForeignKey(sp => sp.SolutionId);

        builder.Entity<SolutionProduct>()
            .HasOne(sp => sp.Product)
            .WithMany(p => p.SolutionProducts)
            .HasForeignKey(sp => sp.ProductId);

        
    }
}
