using System.Collections.Generic;
using System.Collections;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FactorySpace.Models
{
  public class Machine
  {
    public Machine()
    {
      this.JoinEntities = new HashSet<MachineEngineer>();
    }
    
    [Display(Name="Machine Id")]
    public int MachineId { get; set; }

    [Display(Name="Machine Name")]
    public string MachineName { get; set; }

    public virtual ICollection<MachineEngineer> JoinEntities { get; set; }
  }
}