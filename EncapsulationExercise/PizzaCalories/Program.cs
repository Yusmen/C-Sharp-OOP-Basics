using System;

namespace PizzaCalories
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var pizza = new Pizza();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "END")
                {
                    break;
                }
                string[] tokens = input.Split();
                string command = tokens[0];


                
                if (command == "Dough")
                {
                    string flour = tokens[1];
                    string bakingTech = tokens[2];
                    double weight = double.Parse(tokens[3]);
                    var dough = new Dough(flour, bakingTech, weight);
                    pizza.Dough = dough;
                   
                }
                else if (command == "Topping")
                {
                    string type = tokens[1];
                    double weight = double.Parse(tokens[2]);
                    var topping = new Topping(type, weight);
                    pizza.AddTopping(topping);
                  
                }
                else if (command == "Pizza")
                {
                    string name = tokens[1];
                    pizza.Name=name;
                }
                
 
            }

            Console.WriteLine($"{pizza.Name} - {pizza.Calories():f2} Calories.");
           
        }
    }
}
