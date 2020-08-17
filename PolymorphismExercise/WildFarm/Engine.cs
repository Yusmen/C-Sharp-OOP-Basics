using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm
{
    public class Engine
    {
        private List<Animal> animals;
        public Engine()
        {
            animals = new List<Animal>();
        }


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
                    cat.Sound();
                    if (typeFood.ToLower() == "vegetable" || typeFood.ToLower() == "fruit") 
                    {
                        cat.Eat(int.Parse(food[1]));
                    }
                    else
                    {
                        Console.WriteLine($"Cat does not eat {typeFood}");
                    }
                    animals.Add(cat);

                }
                else if (typeAnimal == "Dog")
                {

                    Animal dog = new Dog(tokens[1], double.Parse(tokens[2]), tokens[3]);
                    string[] food = Console.ReadLine().Split();
                    string typeFood = food[0];
                    dog.Sound();
                    if (typeFood.ToLower() == "meat")
                    {
                        dog.Eat(int.Parse(food[1]));
   
                    }
                    else
                    {
                        Console.WriteLine($"Dog does not eat {typeFood}");
                    }
                    animals.Add(dog);

                }
                else if (typeAnimal == "Tiger")
                {

                    Animal tiger =new Tiger(tokens[1], double.Parse(tokens[2]), tokens[3],tokens[4]);
                    string[] food = Console.ReadLine().Split();
                    string typeFood = food[0];
                    tiger.Sound();
                    if (typeFood.ToLower() == "meat")
                    {
                        tiger.Eat(int.Parse(food[1]));
                      
                        
                    }
                    else
                    {
                        Console.WriteLine($"Tiger does not eat {typeFood}");
                    }
                    animals.Add(tiger);

                }
                else if (typeAnimal == "Mouse")
                {

                    Animal mouse = new Mouse(tokens[1], double.Parse(tokens[2]), tokens[3]);
                    string[] food = Console.ReadLine().Split();
                    string typeFood = food[0];
                    mouse.Sound();
                    if (typeFood.ToLower() == "vegetable" || typeFood.ToLower() == "fruit")
                    {
                        mouse.Eat(int.Parse(food[1]));
  
                    }
                    else
                    {
                        Console.WriteLine($"Mouse does not eat {typeFood}");
                    }
                    animals.Add(mouse);

                }
                else if (typeAnimal == "Owl")
                {

                    Animal owl = new Owl(tokens[1], double.Parse(tokens[2]), double.Parse(tokens[3]));
                    string[] food = Console.ReadLine().Split();
                    string typeFood = food[0];
                    owl.Sound();
                    if (typeFood.ToLower() == "meat")
                    {
                        owl.Eat(int.Parse(food[1]));

                    }
                    else
                    {
                        Console.WriteLine($"Mouse does not eat {typeFood}");
                    }
                    animals.Add(owl);

                }
                else if (typeAnimal == "Hen")
                {

                    Animal hen = new Hen(tokens[1], double.Parse(tokens[2]), double.Parse(tokens[3]));
                    string[] food = Console.ReadLine().Split();
                    string typeFood = food[0];
                    hen.Sound();
                    if (typeFood.ToLower() == "meat")
                    {
                        hen.Eat(int.Parse(food[1]));

                    }
                    else
                    {
                        Console.WriteLine($"Mouse does not eat {typeFood}");
                    }
                    animals.Add(hen);

                }
            }
            foreach (var animal in animals)
            {
                Console.WriteLine(animal);
            }
        }
    }
}
