using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingSpree
{
    public class Product
    {

        private string name;
        private double cost;

        public Product(string name,double cost)
        {
            this.Name = name;
            this.Cost = cost;
        }

        public double Cost
        {
            get { return cost; }
            set
            {
                if (value < 0)
                {
                    Exception exs = new ArgumentException("Money cannot be negative");
                    Console.WriteLine(exs.Message);
                    Environment.Exit(0);
                }
                cost = value;

            }
        }


        public string Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    Exception exs = new ArgumentException("Name cannot be empty");
                    Console.WriteLine(exs.Message);
                    Environment.Exit(0);
                }
                name = value;
            }
        }
    
    }
}
