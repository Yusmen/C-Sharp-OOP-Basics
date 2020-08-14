using System;
using System.Collections.Generic;

namespace ShoppingSpree
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(new char[] { '=', ';' }, 
                StringSplitOptions.RemoveEmptyEntries);
            List<Person> people = new List<Person>();

            for (int i = 0; i < input.Length; i+=2)
            {
                var person = new Person(input[i], double.Parse(input[i+1]));
                people.Add(person);
            }

          
            string[] pr = Console.ReadLine()
                .Split(new char[] { '=', ';' },
                StringSplitOptions.RemoveEmptyEntries);
            List<Product> products = new List<Product>();

            for (int i = 0; i < pr.Length; i += 2)
            {
                var pro = new Product(pr[i], double.Parse(pr[i+1]));
                products.Add(pro);
            }
          



            while (true)
            {
                string line = Console.ReadLine();
                if (line == "END")
                {
                    break;
                }

                string[] tokens = line.Split();

                string namePerson = tokens[0];
                string nameProduct = tokens[1];
                foreach (var person in people)
                {
                    if (person.Name == namePerson)
                    {
                        foreach (var product in products)
                        {
                            if (product.Name == nameProduct)
                            {
                                if (person.Money < product.Cost)
                                {
                                    Console.WriteLine($"{namePerson} can't afford {nameProduct}");
                                }
                                else
                                {
                                    person.Products.Add(product);
                                    person.Money -= product.Cost;
                                    Console.WriteLine($"{namePerson} bought {nameProduct}");
                                }
                            }
                        }
                    }
                }


                 
            }
            foreach (var person in people)
            {
                
                
                if (person.Products.Count > 0)
                {
                    
                    Console.Write($"{person.Name} - ");
                    foreach (var product in person.Products)
                    {
                        Console.Write($"{product.Name}, ");


                    }
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine($"{person.Name} - Nothing bought");
                }
                
            }



        }
    }
}
