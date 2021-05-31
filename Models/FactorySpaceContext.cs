using Microsoft.EntityFrameworkCore;

namespace FactorySpace.Models
{
  public class FactorySpaceContext : DbContext
  {
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      modelBuilder.Entity<MachineEngineer>()
        .HasIndex(b => new { b.EngineerId, b.MachineId })
        .IsUnique();

      modelBuilder.Entity<Engineer>()
        .HasIndex(engineer => engineer.EngineerName)
        .IsUnique();

      modelBuilder.Entity<Machine>()
        .HasIndex(machine => machine.MachineName)
        .IsUnique();
    }
    //   modelBuilder.Entity<Engineer>().Property(t => t.EngineerName).HasColumnAnnotation("Index", new IndexAnnotation(new IndexAttribute("IX_EngineerName") { IsUnique = true }));
    // }

    // protected override void OnModelCreating(ModelBuilder builder)
    // {
    //   builder.Entity<Account>()
    //     .HasIndex(account => account.Email)
    //     .IsUnique();
    // }

    public virtual DbSet<Machine> Machines { get; set; }
    public virtual DbSet<Engineer> Engineers { get; set; }
    public DbSet<MachineEngineer> MachineEngineer { get; set; }
    
    

    public FactorySpaceContext(DbContextOptions options) : base(options) { }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseLazyLoadingProxies();
    }
  }
}

