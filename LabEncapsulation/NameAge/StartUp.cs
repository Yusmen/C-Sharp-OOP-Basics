using System;
using System.Collections.Generic;
using System.Linq;

namespace PersonsInfo

{
   public  class StartUp

    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Person> people=new List<Person>();
            

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                Person person = new Person(input[0], input[1],
                    int.Parse(input[2]),decimal.Parse(input[3]));
                people.Add(person);

            }
            Team team = new Team("Softuni");
            
            foreach(var p in people)
            {
                team.AddPlayer(p);
            }
            Console.WriteLine($"First team has {team.FirstTeam.Count} players.");
            Console.WriteLine($"Reserve team has {team.ReserveTeam.Count} players.");
            
        }
    }
}
