using System;
using System.Collections.Generic;
using System.Text;

namespace BorderControl
{
    public class Pet : IBirths
    {
        public string Birthdate { get ; set ; }
        public string Name { get; set; }

        public Pet(string name,string bithdate)
        {
            Name = name;
            Birthdate = bithdate;
        }
    }
}
