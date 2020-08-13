

namespace Google
{

    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Person> people = new Dictionary<string, Person>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "End")
                {
                    break;
                }

                string[] tokens = input.Split(new []{' '},StringSplitOptions.RemoveEmptyEntries);

                string name = tokens[0];
                string command = tokens[1];
                if(!people.ContainsKey(name))
                {
                    people[name] = new Person(name);
                }
                if (command == "company")
                {
                    string companyName = tokens[2];
                    string department = tokens[3];
                    double salary = double.Parse(tokens[4]);
                    var company = new Company(companyName, department, salary);
                    people[name].Company = company;
                }
                else if (command == "pokemon")
                {
                    string namePok = tokens[2];
                    string typePok = tokens[3];

                    var pokeomon = new Pokemon(namePok, typePok);
                    people[name].Pokemons.Add(pokeomon);
                }
                else if (command == "parents")
                {
                    string parentName = tokens[2];
                    string parentBirth = tokens[3];
                    var parent = new Parent(parentName, parentBirth);
                    people[name].Parents.Add(parent);
                }
                else if (command == "children")
                {
                    string childName = tokens[2];
                    string childBirth = tokens[3];
                    var child = new Child(childName, childBirth);
                    people[name].Children.Add(child);
                }
                else if (command == "car")
                {
                    string carModel = tokens[2];
                    string carSpeed = tokens[3];
                    var car = new Car(carModel, carSpeed);
                    people[name].Car = car;
                }
            }

            string searchName = Console.ReadLine();
            Person person = people.Values.FirstOrDefault(p => p.Name == searchName);
            Console.WriteLine(person);

        }
    }
}
