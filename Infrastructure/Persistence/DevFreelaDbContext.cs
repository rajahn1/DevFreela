using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Infrastructure.Persistence;

public class DevFreelaDbContext : DbContext

{
    public DevFreelaDbContext(DbContextOptions<DevFreelaDbContext> options) : base(options)
    {
    }
    public DbSet<Project>Projects { get; set; }
    public DbSet<User>Users { get; set; }
    public DbSet<Skill>Skills { get; set; }
    
    public DbSet<UserSkill> UserSkills { get; set; }
    public DbSet<ProjectComment> ProjectComments { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Category>()
            .HasKey(c => c.Id);
        modelBuilder.Entity<Project>()
            .HasKey(p => p.Id);
        modelBuilder.Entity<Project>()
            .HasOne(p => p.Freelancer)
            .WithMany(f => f.FreelanceProjects)
            .HasForeignKey(p => p.IdFreelancer)
            .OnDelete(DeleteBehavior.Restrict);
        
        modelBuilder.Entity<Project>()
            .HasOne(p => p.Client)
            .WithMany(f => f.OwnedProjects)
            .HasForeignKey(p => p.IdClient)
            .OnDelete(DeleteBehavior.Restrict);
            
        modelBuilder.Entity<ProjectComment>()
            .HasKey(p => p.Id);
        modelBuilder.Entity<Skill>()
            .HasKey(p => p.Id);;
        
        modelBuilder.Entity<User>()
            .HasKey(p => p.Id);;

        modelBuilder.Entity<User>()
            .HasMany(u => u.Skills)
            .WithOne();
        
        modelBuilder.Entity<UserSkill>()
            .HasKey(p => p.Id);;
    }
}
