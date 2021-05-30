using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace FactorySpace.Models
{
  public class FactorySpaceContextFactory : IDesignTimeDbContextFactory<FactorySpaceContext>
  {

    FactorySpaceContext IDesignTimeDbContextFactory<FactorySpaceContext>.CreateDbContext(string[] args)
    {
      IConfigurationRoot configuration = new ConfigurationBuilder()
        .SetBasePath(Directory.GetCurrentDirectory())
        .AddJsonFile("appsettings.json")
        .Build();

      var builder = new DbContextOptionsBuilder<FactorySpaceContext>();

      builder.UseMySql(configuration["ConnectionStrings:DefaultConnection"], ServerVersion.AutoDetect(configuration["ConnectionStrings:DefaultConnection"]));

      return new FactorySpaceContext(builder.Options);
    }
  }
}