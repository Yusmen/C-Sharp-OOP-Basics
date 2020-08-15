using MilitaryElite.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite
{
    public class Private:Soldier,IPrivate
    {
        

        public double Salary { get; set; }
        

        public Private(string id, string firstName, string lastName,double salary) 
            : base(id, firstName, lastName)
        {
            this.Salary = salary;
        }

        public override string ToString()
        {
            return $"Name: {FirstName} {LastName} Id: {Id} Salary: {Salary:f2}";
        }

    }
}
