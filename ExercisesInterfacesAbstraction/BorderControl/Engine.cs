using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BorderControl
{
    public class Engine
    {

        private List<IIdentifiable> creatures;
        private List<IBirths> births;
     

        public Engine()
        {
            creatures = new List<IIdentifiable>();
            births = new List<IBirths>();
            
                
        }
        //Problem 5
        public void firstRun()
        {
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "End") 
                {
                    break;
                }
                string[] tokens = input.Split();
                if (tokens.Length == 3)
                {
                    Citizen citizen = new Citizen(tokens[0], int.Parse(tokens[1]), tokens[2]);
                    creatures.Add(citizen);
                }
                else
                {
                    Robot robot = new Robot(tokens[0], tokens[1]);
                    creatures.Add(robot);
                }

            }
            string fake = Console.ReadLine();

            foreach (var item in creatures.Where(x=>x.Id.EndsWith(fake)))
            {
                Console.WriteLine(item.Id);

            }
        }
        //Problem 6
        public void secondRun()
        {
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "End")
                {
                    break;
                }

                string[] tokens = input.Split();
                string type = tokens[0];

                if (type=="Citizen")
                {
                    Citizen citizen = new Citizen(tokens[1], 
                        int.Parse(tokens[2]), tokens[3],tokens[4]);
                    births.Add(citizen);
                }
                else if(type=="Pet")
                {

                    Pet pet = new Pet(tokens[1], tokens[2]);
                    births.Add(pet);
                }
            }

            string year = Console.ReadLine();
            var currentBirths = births.Where(x => x.Birthdate.EndsWith(year)).ToList();



            foreach (var item in currentBirths)
            {
                Console.WriteLine(item.Birthdate);
            }
            currentBirths.RemoveAll(x => !x.Birthdate.EndsWith(year));
            if (currentBirths.Count == 0)
            {
                Console.WriteLine("<empty output>");
            }

        }



    }
}
