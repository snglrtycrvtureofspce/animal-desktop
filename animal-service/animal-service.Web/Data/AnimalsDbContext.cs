using animal_service.Models;
using Microsoft.EntityFrameworkCore;

namespace animal_service.Data;

/// <summary>
/// Database context
/// </summary>
public class AnimalsDbContext : DbContext
{
    public DbSet<UserEntity> Users { get; set; }
    public DbSet<RoleEntity> Roles { get; set; }
    public DbSet<AnimalEntity> Animals { get; set; }
    public DbSet<MarkerEntity> Markers { get; set; }
    
    public AnimalsDbContext(DbContextOptions<AnimalsDbContext> opt) : base(opt) { }

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
                    .HasOne(ur => ur.RoleEntity)
                    .WithMany()
                    .HasForeignKey(ur => ur.RoleId),
                j => j
                    .HasOne(ur => ur.UserEntity)
                    .WithMany()
                    .HasForeignKey(ur => ur.UserId)
            );
        
        modelBuilder.Entity<AnimalEntity>()
            .HasMany(u => u.Markers)
            .WithMany(r => r.Animals)
            .UsingEntity<AnimalMarkerEntity>(
                j => j
                    .HasOne(ur => ur.MarkerEntity)
                    .WithMany()
                    .HasForeignKey(ur => ur.MarkerId),
                j => j
                    .HasOne(ur => ur.AnimalEntity)
                    .WithMany()
                    .HasForeignKey(ur => ur.AnimalId)
            );
        
        modelBuilder.Entity<AnimalEntity>()
            .HasMany(u => u.Users)
            .WithMany(r => r.Animals)
            .UsingEntity<AnimalUserEntity>(
                j => j
                    .HasOne(ur => ur.UserEntity)
                    .WithMany()
                    .HasForeignKey(ur => ur.UserId),
                j => j
                    .HasOne(ur => ur.AnimalEntity)
                    .WithMany()
                    .HasForeignKey(ur => ur.AnimalId)
            );
        
        base.OnModelCreating(modelBuilder);
    }
}