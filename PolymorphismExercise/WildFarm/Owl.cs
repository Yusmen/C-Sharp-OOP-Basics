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

        public override void Eat(int quantity)
        {
            this.Weight += 0.25 * quantity;
            FoodEaten += quantity;
        }
        public override string ToString()
        {
            return $"Owl [{Name}, {WingSize}, {Weight}, {FoodEaten}]";
        }
    }
}
