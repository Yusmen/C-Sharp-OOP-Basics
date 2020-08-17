﻿using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm
{
    public class Dog : Mammal
    {
        public Dog(string name, double weight, string livingRegion) 
            : base(name, weight, livingRegion)
        {
        }


        public override void Sound()
        {
            Console.WriteLine("Woof!");
        }
        public override void Eat(int quantity)
        {
            this.Weight += 0.40 * quantity;
            FoodEaten += quantity;
        }
        public override string ToString()
        {
            return $"Dog [{Name}, {Weight}, {LivingRegion}, {FoodEaten}]";
        }

    }
}
