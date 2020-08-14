using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public class Engine
    {

        public void Run()
        {
            while (true)
            {

                try
                {


                    string typeAnimal = Console.ReadLine();
                    if (typeAnimal == "Beast!")
                    {
                        break;
                    }

                    if (typeAnimal.ToLower() == "cat")
                    {
                        string[] input = Console.ReadLine().Split();

                        Cat cat = new Cat(input[0], int.Parse(input[1]), input[2]);

                        Console.WriteLine(cat);
                    }
                    else if (typeAnimal.ToLower() == "dog")
                    {
                        string[] input = Console.ReadLine().Split();

                        Dog dog = new Dog(input[0], int.Parse(input[1]), input[2]);
                        Console.WriteLine(dog);
                    }
                    else if (typeAnimal.ToLower() == "frog")
                    {
                        string[] input = Console.ReadLine().Split();

                        Frog frog = new Frog(input[0], int.Parse(input[1]), input[2]);
                        Console.WriteLine(frog);
                    }
                    else if (typeAnimal.ToLower() == "kitten")
                    {
                        string[] input = Console.ReadLine().Split();

                        Kitten kitten = new Kitten(input[0], int.Parse(input[1]));
                        Console.WriteLine(kitten);
                    }
                    else if (typeAnimal.ToLower() == "tomcat")
                    {
                        string[] input = Console.ReadLine().Split();

                        Tomcat tomcat = new Tomcat(input[0], int.Parse(input[1]));
                        Console.WriteLine(tomcat);
                    }
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                }
                

            }
        }
    }
}
