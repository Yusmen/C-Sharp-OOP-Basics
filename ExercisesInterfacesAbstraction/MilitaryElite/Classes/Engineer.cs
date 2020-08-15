using MilitaryElite.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite
{
    public class Engineer : Private,IEngineer
    {

        public string Corps { get; set; }
        public List<Repair> Repairs { get; set; }
        public Engineer(string id, string firstName, string lastName, double salary,string corps) 
            : base(id, firstName, lastName, salary)
        {
            Corps = corps;
            Repairs = new List<Repair>();
        }


        public override string ToString()
        {
            StringBuilder st = new StringBuilder();
            if (Repairs.Count > 0)
            {
                st.AppendLine($"Name: {FirstName} {LastName} Id: {Id} Salary: {Salary:f2}");
                st.AppendLine($"Corps: {Corps}");
                st.AppendLine("Repairs:");
                foreach (var item in Repairs)
                {
                    st.AppendLine($"  Part Name: {item.PartName} Hours Worked: {item.Hours}");

                }
            }
            return st.ToString();
        }
    }
}
