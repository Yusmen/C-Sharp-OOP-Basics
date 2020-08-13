using System;
using System.Collections.Generic;

namespace DefiningClasses
{
    public class StartUp
    {

        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Family fam = new Family();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();

                string name = input[0];
                int age = int.Parse(input[1]);

                Person pr = new Person(name, age);
               
                fam.AddMember(pr);
            }
            List<Person> person = fam.GetOldestMember();
            foreach(var item in person)
            {
                Console.WriteLine($"{item.Name} - {item.Age}");
            }

            

           
            

            
        }
    }
}
