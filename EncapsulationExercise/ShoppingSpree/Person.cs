using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingSpree
{
  public class Person
    {

        private string name;
        private double money;
        private List<Product> products;

        public Person(string name,double money)
        {
            this.Name = name;
            this.Money = money;
            this.products = new List<Product>();
        }

        public List<Product> Products
        {
            get { return products; }
            set { products = value; }
        }


        public double Money
        {
            get { return money; }
            set
            {
                if (value<0)
                {
                    Exception exs = new ArgumentException("Money cannot be negative");
                    Console.WriteLine(exs.Message);
                    Environment.Exit(0);
                }
                money = value;

            }
        }

        public string Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrEmpty(value)||string.IsNullOrWhiteSpace(value)) 
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
