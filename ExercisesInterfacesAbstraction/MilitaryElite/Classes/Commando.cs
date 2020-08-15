using MilitaryElite.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite
{
    public class Commando:Private,ICommando
        
    {



        public string Corps { get; set; }
        public List<Mission> Missions { get; set; }

        public Commando(string id, string firstName, string lastName, double salary,string corps)
            : base(id, firstName, lastName, salary)
        {
            Corps = corps;
            Missions = new List<Mission>();

        }

        public override string ToString()
        {
            StringBuilder st = new StringBuilder();

          
            {
                st.AppendLine($"Name: {FirstName} {LastName} Id: {Id} Salary: {Salary:f2}");
                st.AppendLine($"Corps: {Corps}");
                st.AppendLine("Missions:");
                foreach (var item in Missions)
                {
                    if (item.State.ToLower() != "finished") 
                    {
                        st.AppendLine($"  Code Name: {item.CodeName} State: {item.State}");
                    }
                    

                }

            }
            return st.ToString();
        }


    }
}
