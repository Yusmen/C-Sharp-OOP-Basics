using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm
{
    public abstract class Mammal : Animal
    {

        public string LivingRegion { get; set; }


        public Mammal(string name, double weight,string livingRegion) 
            : base(name, weight)
        {

            this.LivingRegion = livingRegion;
        }
        public virtual void Eat()
        {

        }

        public override string ToString()
        {
            return $"{this.GetType()} [{Name}, {Weight}, {LivingRegion}, {FoodEaten}]";
        }
    }
}
