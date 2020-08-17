using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm
{
    public class Mouse : Mammal
    {
        public Mouse(string name, double weight, string livingRegion) 
            : base(name, weight, livingRegion)
        {
        }

        public override void Sound()
        {
            Console.WriteLine("Squeak");
        }
        public override void Eat(int quantity)
        {
            this.Weight += 0.10 * quantity;
            FoodEaten += quantity;
        }
        public override string ToString()
        {
            return $"Mouse [{Name}, {Weight}, {LivingRegion}, {FoodEaten}]";
        }


    }
}
