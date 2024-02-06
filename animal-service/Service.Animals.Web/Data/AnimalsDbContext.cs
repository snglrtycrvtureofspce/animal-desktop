using Microsoft.EntityFrameworkCore;
using Service.Animals.Web.Models;
using snglrtycrvtureofspce.Core.Infrastructure;

namespace Service.Animals.Web.Data;

/// <summary>
/// Database context
/// </summary>
public class AnimalsDbContext : DbContext
{
    public virtual DbSet<UserEntity> Users { get; set; }
    public virtual DbSet<RoleEntity> Roles { get; set; }
    public virtual DbSet<AnimalEntity> Animals { get; set; }
    public virtual DbSet<MarkerEntity> Markers { get; set; }
    
    public AnimalsDbContext(DbContextOptions<AnimalsDbContext> opt) : base(opt) { }
    public AnimalsDbContext() { }

    /// <inheritdoc />
    public override int SaveChanges()
    {
        ChangeTracker.DetectChanges();

        var added = ChangeTracker
            .Entries()
            .Where(w => w.State == EntityState.Added)
            .Select(s => s.Entity)
            .ToList();

        foreach (var entry in added)
        {
            if (entry is not IEntity entity)
            {
                continue;
            }
            
            entity.CreatedDate = DateTime.UtcNow;
            entity.ModificationDate = DateTime.UtcNow;
        }

        var updated = ChangeTracker
            .Entries()
            .Where(w => w.State == EntityState.Modified)
            .Select(s => s.Entity)
            .ToList();

        foreach (var entry in updated)
        {
            if (entry is IEntity entity)
            {
                entity.ModificationDate = DateTime.UtcNow;
            }
        }

        return base.SaveChanges();
    }

    /// <inheritdoc />
    public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new())
    {
        return Task.Run(SaveChanges, cancellationToken);
    }

    /// <inheritdoc />
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<UserEntity>().HasKey(u => u.Id);
        modelBuilder.Entity<RoleEntity>().HasKey(r => r.Id);
        modelBuilder.Entity<AnimalEntity>().HasKey(a => a.Id);
        modelBuilder.Entity<MarkerEntity>().HasKey(m => m.Id);
        
        modelBuilder.Entity<UserEntity>()
            .HasMany(u => u.Roles)
            .WithMany(r => r.Users)
            .UsingEntity<UserRoleEntity>(
                j => j
                    .HasOne(ur => ur.Role)
                    .WithMany()
                    .HasForeignKey(ur => ur.RoleId),
                j => j
                    .HasOne(ur => ur.User)
                    .WithMany()
                    .HasForeignKey(ur => ur.UserId)
            );
        
        modelBuilder.Entity<AnimalEntity>()
            .HasMany(u => u.Markers)
            .WithMany(r => r.Animals)
            .UsingEntity<AnimalMarkerEntity>(
                j => j
                    .HasOne(ur => ur.Marker)
                    .WithMany()
                    .HasForeignKey(ur => ur.MarkerId),
                j => j
                    .HasOne(ur => ur.Animal)
                    .WithMany()
                    .HasForeignKey(ur => ur.AnimalId)
            );
        
        modelBuilder.Entity<AnimalEntity>()
            .HasMany(u => u.Users)
            .WithMany(r => r.Animals)
            .UsingEntity<AnimalUserEntity>(
                j => j
                    .HasOne(ur => ur.User)
                    .WithMany()
                    .HasForeignKey(ur => ur.UserId),
                j => j
                    .HasOne(ur => ur.Animal)
                    .WithMany()
                    .HasForeignKey(ur => ur.AnimalId)
            );
        
        base.OnModelCreating(modelBuilder);
    }
}