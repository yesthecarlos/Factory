using Microsoft.EntityFrameworkCore;

namespace FactorySpace.Models
{
  public class FactorySpaceContext : DbContext
  {
    public virtual DbSet<Machine> Machines { get; set; }
    public DbSet<Engineer> Engineers { get; set; }
    public DbSet<MachineEngineer> MachineEngineer { get; set; }

    public FactorySpaceContext(DbContextOptions options) : base(options) { }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseLazyLoadingProxies();
    }
  }
}