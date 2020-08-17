using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm
{
    public class Tiger : Feline
    {

        public Tiger(string name, double weight, string livingRegion,string breed) 
            : base(name, weight,  livingRegion,breed)
        {
            
        }

        public override void Sound()
        {
            Console.WriteLine("ROAR!!!");
        }
        public override void Eat(int quantity)
        {
            this.Weight += 1.00 * quantity;
            FoodEaten += quantity;
        }
        public override string ToString()
        {
            return $"Tiger [{Name}, {Breed}, {Weight}, {LivingRegion}, {FoodEaten}]";
        }
    }
}
