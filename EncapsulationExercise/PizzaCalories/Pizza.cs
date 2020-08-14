using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaCalories
{
    class Pizza
    {

        private string name;
        private Dough dough;
        private List<Topping> toppings;

        public Pizza()
        {
            this.toppings = new List<Topping>();
        }


        public Pizza(string name)
        {
            this.Name = name;
           
        }
        public List<Topping> Toppings
        {
            get { return toppings; }
            set
            {
                if (value.Count < 0 || value.Count > 10)
                {
                    Exception exs = new Exception("Number of toppings should be in range [0..10].");
                    Console.WriteLine(exs.Message);
                    Environment.Exit(0);
                }

                toppings = value;
            }
        }

        public Dough Dough
        {
            get { return dough; }
            set { dough = value; }
        }


        public string Name
        {
            get { return name; }
            set
            {
                if (value == string.Empty || value.Length > 15)
                {

                    Exception exs = new Exception("Pizza name should be between 1 and 15 symbols.");
                    Console.WriteLine(exs.Message);
                    Environment.Exit(0);
                   

                }


                name = value;
            }




        }
        public void AddTopping(Topping topping)
        {
            if (toppings.Count == 10) 
            {
                Exception exs = new Exception("Number of toppings should be in range [0..10].");
                Console.WriteLine(exs.Message);
                Environment.Exit(0);
            }
            else
            {
                
                toppings.Add(topping);
            }
        }

        public double Calories()
        {
            double result = dough.Calories();
            foreach (var topp in toppings)
            {
                result += topp.Calories();
            }
            return result;
        }

    }
}
