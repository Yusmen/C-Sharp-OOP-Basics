using MilitaryElite.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite
{
    public class LeutenantGeneral : Private,ILeutenantGeneral
    {

        public List<Private> Privates { get; set; }

        public LeutenantGeneral(string id, string firstName, string lastName, double salary) 
            : base(id, firstName, lastName, salary)
        {
            Privates = new List<Private>();

        }

        public override string ToString()
        {
            StringBuilder st = new StringBuilder();
            st.AppendLine($"Name: {FirstName} {LastName} Id: {Id} Salary: {Salary:f2}");
            st.AppendLine("Privates:");
            foreach (var item in Privates)
            {

                st.AppendLine($"Name: {item.FirstName} {item.LastName} Id: {item.Id} Salary: {item.Salary:f2}");
            }

            return st.ToString();
        }

    }
}
