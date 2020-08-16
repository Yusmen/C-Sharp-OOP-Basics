﻿using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm
{
    public abstract class Bird : Animal
    {

        public double WingSize { get; set; }

        public Bird(string name, double weight, double wingSize) 
            : base(name, weight)
        {
            this.WingSize = wingSize;
        }
        public virtual void Eat()
        {

        }


        public override string ToString()
        {
            return $"{this.GetType()} [{Name}, {WingSize}, {Weight}, {FoodEaten}]";
        }
    }
}