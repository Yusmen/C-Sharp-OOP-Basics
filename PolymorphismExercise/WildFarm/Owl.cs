using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm
{
    public class Owl : Bird
    {
        public Owl(string name, double weight,  double wingSize) 
            : base(name, weight,  wingSize)
        {
        }

        public override void Sound()
        {
            Console.WriteLine("Hoot Hoot");
        }

        public override void Eat()
        {
            this.Weight += 0.25;
        }
    }
}
