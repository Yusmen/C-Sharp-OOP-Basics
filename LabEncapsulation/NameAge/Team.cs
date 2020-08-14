using System;
using System.Collections.Generic;
using System.Text;


namespace PersonsInfo
{
    public class Team
    {

        private string name;
        private readonly List<Person> firstTeam;
        private readonly  List<Person> reserveTeam;

        public Team(string name)
        {
            this.name = name;
            this.firstTeam = new List<Person>();
            this.reserveTeam = new List<Person>();
        }

        public List<Person> ReserveTeam
        {
            get { return reserveTeam; }
            
        }


        public List<Person> FirstTeam
        {
            get { return firstTeam; }
            
        }


        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public void AddPlayer(Person player)
        {
            if (player.Age < 40)
            {
                firstTeam.Add(player);
            }
            else
            {
                reserveTeam.Add(player);
            }
        }

    }
}
