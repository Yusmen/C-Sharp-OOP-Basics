using MilitaryElite.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite
{
    public class Mission:IMission
    {

        public string CodeName { get; set; }
        public string State { get; set; }

        public Mission(string codeName,string state)
        {
            CodeName = codeName;
            State = state;
        }


        public void CompleteMission()
        {
            this.State = "Finished";
        }

        public override string ToString()
        {
            string st = string.Empty;
            if(State!="Finished")
            {
                st=$"Code Name: {CodeName} State: {State}";
            }
            return st;
            
        }
    }
}
