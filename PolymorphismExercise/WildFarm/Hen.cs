using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm
{
    public class Hen : Bird
    {
        public Hen(string name, double weight, double wingSize) 
            : base(name, weight,  wingSize)
        {
        }


        public override void Sound()
        {
            Console.WriteLine("Cluck");
        }

        public override void Eat()
        {
            this.Weight += 0.35;
        }
    }
}
