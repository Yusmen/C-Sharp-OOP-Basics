using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaCalories
{
    class Topping
    {

        private string type;
        private double weight;

        public Topping(string type, double weight)
        {
            this.Type = type;
            this.Weight = weight;
        }

        public double Weight
        {
            get { return weight; }
            set
            {
                if (value < 1 || value > 50)
                {
                    Exception exs = new
                        ArgumentException($"{Type} weight should be in the range [1..50].");
                    Console.WriteLine(exs.Message);
                    Environment.Exit(0);
                }
                weight = value;
            }
        }
        

        public string Type
        {
            get { return type; }
            set
            {
                if (value.ToLower() != "meat" && value.ToLower() != "veggies" && value.ToLower() != "cheese" && value.ToLower() != "sauce")
                {
                    Exception exs = new
                        ArgumentException($"Cannot place {value} on top of your" +
                        $" pizza.");
                    Console.WriteLine(exs.Message);
                    Environment.Exit(0);


                }
                type = value;
            }
        }
        
        public double Calories()
        {

            double result = 0;
            if (this.Type.ToLower() == "meat")
            {
                result=2 * weight * 1.2;
            }
            else if (Type.ToLower() == "veggies")
            {
                result=2 * weight * 0.8;
            }
            else if (Type.ToLower() == "cheese")
            {
                result=2 * weight * 1.1;
            }
            else if (Type.ToLower() == "sauce")
            {
                result = 2 * weight * 0.9;
            }
            return result;
        }

    }
}
