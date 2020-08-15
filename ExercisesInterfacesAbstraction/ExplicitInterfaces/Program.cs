using System;

namespace ExplicitInterfaces
{
    public class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "End") 
                {
                    break;
                }
                string[] tokens = input.Split();
                IPerson iperson = new Citizen(tokens[0]);
                IResident resident = new Citizen(tokens[0]);
                Console.WriteLine(iperson.GetName());
                Console.WriteLine(resident.GetName());
            }
        }
    }
}
