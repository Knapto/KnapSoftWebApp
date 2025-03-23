using KnapSoft.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace KnapSoft.Data;

public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<Product> Products { get; set; }
    public DbSet<Solution> Solutions { get; set; }
    public DbSet<SolutionProduct> SolutionProducts { get; set; }
    public DbSet<BlogPost> BlogPosts { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        // Přemapování datetimeoffset na datetime
        foreach (var entityType in builder.Model.GetEntityTypes())
        {
            foreach (var property in entityType.GetProperties())
            {
                if (property.ClrType == typeof(DateTimeOffset) || property.ClrType == typeof(DateTimeOffset?))
                {
                    property.SetColumnType("datetime");
                }
            }
        }

        // Many-to-many: Solution ↔ Product
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

        // MariaDB compatibility for Identity (nvarchar(max) → longtext)
        builder.Entity<IdentityRole>(entity =>
        {
            entity.Property(e => e.ConcurrencyStamp).HasColumnType("longtext");
        });

        builder.Entity<IdentityUser>(entity =>
        {
            entity.Property(e => e.ConcurrencyStamp).HasColumnType("longtext");
            entity.Property(e => e.SecurityStamp).HasColumnType("longtext");
        });

        builder.Entity<IdentityUserLogin<string>>(entity =>
        {
            entity.Property(e => e.LoginProvider).HasMaxLength(128);
            entity.Property(e => e.ProviderKey).HasMaxLength(128);
        });

        builder.Entity<IdentityUserToken<string>>(entity =>
        {
            entity.Property(e => e.LoginProvider).HasMaxLength(128);
            entity.Property(e => e.Name).HasMaxLength(128);
        });

        builder.Entity<IdentityUserRole<string>>(entity =>
        {
            entity.Property(e => e.UserId).HasMaxLength(450);
            entity.Property(e => e.RoleId).HasMaxLength(450);
        });
        builder.Entity<Product>(entity =>
        {
            entity.Property(e => e.Name).HasColumnType("longtext").IsRequired();
            entity.Property(e => e.Description).HasColumnType("longtext").IsRequired();
        });
        builder.Entity<Solution>(entity =>
        {
            entity.Property(e => e.Name).HasColumnType("longtext").IsRequired();
            entity.Property(e => e.Description).HasColumnType("longtext");
            entity.Property(e => e.LargeDescription).HasColumnType("longtext");
        });
        builder.Entity<IdentityUserRole<string>>(entity =>
        {
            entity.Property(e => e.UserId).HasMaxLength(191);
            entity.Property(e => e.RoleId).HasMaxLength(191);
        });
    }
}
