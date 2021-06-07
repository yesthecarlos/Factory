using System.Collections.Generic;
using System.Collections;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FactorySpace.Models
{
  public class Engineer
  {
    public Engineer()
    {
      this.JoinEntities = new HashSet<MachineEngineer>();
    }

    [Display(Name="Engineer Id")]
    public int EngineerId { get; set; }

    [Display(Name="Engineer Name")]
    public string EngineerName { get; set; }

    public virtual ICollection<MachineEngineer> JoinEntities { get; set; }
  }
}
