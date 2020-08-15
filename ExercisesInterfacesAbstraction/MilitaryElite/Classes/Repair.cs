using MilitaryElite.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite
{
    public class Repair:IRepair
    {
        public string PartName { get; set; }
        public int Hours { get; set; }

        public Repair(string partName,int hours)
        {
            PartName = partName;
            Hours = hours;
        }


        public override string ToString()
        {
            StringBuilder st = new StringBuilder();


            st.AppendLine($"Part Name: {PartName} Hours Worked: {Hours}");
            return st.ToString();
        }
    }
}
