using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm
{
    public class Engine
    {


        public void Run()
        {


            while(true)
            {
                string input = Console.ReadLine();
                if (input == "End") 
                {
                    break;
                }

                string[] tokens = input.Split();
                string typeAnimal = tokens[0];

                if (typeAnimal == "Cat")
                {

                    
                    Animal cat = new Cat(tokens[1],double.Parse(tokens[2]),tokens[3],tokens[4]);
                

                    string[] food = Console.ReadLine().Split();
                    string typeFood = food[0];
                    if (typeFood.ToLower() == "vegetable" || typeFood.ToLower() == "fruit") 
                    {
                        cat.Eat(int.Parse(food[1]));
                        cat.Sound();
                        Console.WriteLine(cat);
                    }
                    

                }

            }
        }
    }
}
