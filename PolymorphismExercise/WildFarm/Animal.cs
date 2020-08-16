using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm
{
    public abstract class Animal
    {

        public string Name { get; set; }
        public double Weight { get; set; }

        public double FoodEaten { get; set; }
        

        public Animal(string name,double weight)
        {
            Name = name;
            Weight = weight;
            
        }

        public virtual void Sound()
        {
            Console.WriteLine("Sounddd");
        }
        public virtual void Eat(int quantity)
        {

        }

    }
}
