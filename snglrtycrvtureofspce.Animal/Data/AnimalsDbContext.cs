using Microsoft.EntityFrameworkCore;
using snglrtycrvtureofspce.Animal.Data.Entities;
using snglrtycrvtureofspce.Core.Base.Infrastructure;

namespace snglrtycrvtureofspce.Animal.Data;

public class AnimalsDbContext : DbContext
{
    public virtual DbSet<UserEntity> Users { get; set; }
    
    public virtual DbSet<RoleEntity> Roles { get; set; }
    
    public virtual DbSet<AnimalTypeEntity> AnimalTypes { get; set; }
    
    public virtual DbSet<AnimalEntity> Animals { get; set; }
    
    public virtual DbSet<LocationEntity> Locations { get; set; }
    
    public virtual DbSet<MovementPointEntity> MovementPoints { get; set; }

    public AnimalsDbContext(DbContextOptions<AnimalsDbContext> opt) : base(opt) { }

    public AnimalsDbContext() { }

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

    public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new())
    {
        return Task.Run(SaveChanges, cancellationToken);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<UserEntity>().HasKey(u => u.Id);
        modelBuilder.Entity<RoleEntity>().HasKey(r => r.Id);
        modelBuilder.Entity<AnimalTypeEntity>().HasKey(a => a.Id);
        modelBuilder.Entity<AnimalEntity>().HasKey(a => a.Id);
        modelBuilder.Entity<LocationEntity>().HasKey(m => m.Id);
        modelBuilder.Entity<MovementPointEntity>().HasKey(a => a.Id);

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

        base.OnModelCreating(modelBuilder);
    }
}