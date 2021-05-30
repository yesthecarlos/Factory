using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FactorySpace.Models

{
  [Index(nameof(EngineerId), nameof(MachineId), IsUnique = true)]
  public class MachineEngineer
    {       
      public int MachineEngineerId { get; set; }
      public int EngineerId { get; set; }
      public int MachineId { get; set; }
      public virtual Engineer Engineer { get; set; }
      public virtual Machine Machine { get; set; }
    }
}