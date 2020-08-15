using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.Interfaces
{
    public interface IEngineer
    {

         string Corps { get; set; }
         List<Repair> Repairs { get; set; }
    }
}
