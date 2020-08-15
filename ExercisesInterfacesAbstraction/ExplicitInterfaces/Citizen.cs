using System;
using System.Collections.Generic;
using System.Text;

namespace ExplicitInterfaces
{
    public class Citizen : IPerson, IResident
    {
        public string Name { get ;set ; }
        
        public int Age { get ; set; }
        public string Country { get; set; }

        public Citizen(string name)
        {
            Name = name;
        }

        string IPerson.GetName()
        {
            return Name;
        }

        string IResident.GetName()
        {
            return $"Mr/Ms/Mrs {this.Name}";
        }
    }
}
