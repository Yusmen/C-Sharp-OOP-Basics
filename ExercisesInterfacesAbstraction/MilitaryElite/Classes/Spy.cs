using MilitaryElite.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite
{
    public class Spy : Soldier,ISpy
    {

        public int CodeNumber { get; set; }

        public Spy(string id, string firstName, string lastName,int codenumber) 
            : base(id, firstName, lastName)
        {
            CodeNumber = codenumber;
        }

        public override string ToString()
        {


            StringBuilder st = new StringBuilder();
            st.AppendLine($"Name: {FirstName} {LastName} Id: {Id}");
            st.AppendLine($"Code Number: {CodeNumber}");

            return st.ToString();

        }
    }
}
