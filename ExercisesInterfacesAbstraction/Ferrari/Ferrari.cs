using System;
using System.Collections.Generic;
using System.Text;

namespace Ferrari
{
    public class Ferrari : ICar
    {
        public string Name { get; set ; }
        public string Model { get ; set; }


        public Ferrari(string name)
        {
            Name = name;
            Model = "488-Spider";
        }
        public string Brake()
        {
            return "Brakes!";
        }

        public string Gas()
        {
            return "Gaaaaaasssss";
        }

        public override string ToString()
        {
            return $"{Model}/{Brake()}/{Gas()}/{Name}";
        }
    }
}
