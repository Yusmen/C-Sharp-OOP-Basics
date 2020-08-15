using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite
{
    public class Engine
    {

        private List<Private> privates;

        public Engine()
        {
            this.privates = new List<Private>();
        }

        public void Run()
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



                if (type == "Private")
                {
                    string id = tokens[1];
                    string firstName = tokens[2];
                    string lastName = tokens[3];
                    double salary = double.Parse(tokens[4]);
                    Private priva = new Private(id, firstName, lastName, salary);
                    privates.Add(priva);
                    Console.WriteLine(priva);


                }
                else if (type == "Spy")
                {
                    Spy spy = new Spy(tokens[1], tokens[2], tokens[3],int.Parse(tokens[4]));
                    Console.WriteLine(spy);
                }
                else if (type == "LieutenantGeneral")
                {
                    LeutenantGeneral lg = new LeutenantGeneral(tokens[1], tokens[2],
                        tokens[3], double.Parse(tokens[4]));
                    if (tokens.Length > 5)
                    {
                        for (int i = 5; i < tokens.Length; i++)
                        {
                            foreach (var item in privates)
                            {
                                if (item.Id == tokens[i])
                                {
                                    lg.Privates.Add(item);
                                }
                            }
                        }
                    }
                    Console.WriteLine(lg);

                }
                else if (type == "Engineer")
                {
                    Engineer engineer = new Engineer(tokens[1], tokens[2],tokens[3], double.Parse(tokens[4]), tokens[5]);

                    if (tokens.Length > 6)
                    {
                        for (int i = 6; i < tokens.Length; i += 2)
                        {
                            string part = tokens[i];
                            int hours = int.Parse(tokens[i + 1]);
                            Repair repair = new Repair(part, hours);
                            engineer.Repairs.Add(repair);
                        }
                    }
                    Console.WriteLine(engineer);
                }
                else if (type == "Commando")
                {
                    Commando commando = new Commando(tokens[1], tokens[2],
                        tokens[3], double.Parse(tokens[4]), tokens[5]);
                    if (tokens.Length > 6)
                    {
                        for (int i = 6; i < tokens.Length; i += 2)
                        {
                            string codeName = tokens[i];
                            string state = tokens[i + 1];
                            Mission mission = new Mission(codeName, state);
                            commando.Missions.Add(mission);
                        }
                    }
                    Console.WriteLine(commando);



                }


            }
        }
            

    }
}
