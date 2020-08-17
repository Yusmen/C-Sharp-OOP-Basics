using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm
{
    public class Cat : Feline
    {
        
       
        public Cat(string name, double weight,  string livingRegion,string breed) 
            : base(name, weight, livingRegion,breed)
        {
           
        }


        public override void Sound()
        {
            Console.WriteLine("Meow");
        }

        public override void Eat(int quantity)
        {
            this.Weight += 0.30 * quantity;
            FoodEaten += quantity;
        }
        public override string ToString()
        {
            return $"Cat [{Name}, {Breed}, {Weight}, {LivingRegion}, {FoodEaten}]";
        }
    }
}
