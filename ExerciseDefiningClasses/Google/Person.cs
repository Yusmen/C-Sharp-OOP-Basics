using System;
using System.Collections.Generic;
using System.Text;

namespace Google
{


    class Person
    {
        private string name;
        private Company company;
        private List<Pokemon> pokemons;
        private List<Parent> parents;
        private List<Child> children;
        private Car car;

        public Person(string name)
        {
            this.Name = name;
            this.Pokemons = new List<Pokemon>();
            this.Parents = new List<Parent>();
            this.Children = new List<Child>();

        }
        public Car Car
        {
            get { return car; }
            set { car = value; }
        }


        public List<Child> Children
        {
            get { return children; }
            set { children = value; }
        }


        public List<Parent> Parents
        {
            get { return parents; }
            set { parents = value; }
        }



        public List<Pokemon> Pokemons
        {
            get { return pokemons; }
            set { pokemons = value; }
        }


        public Company Company
        {
            get { return company; }
            set { company = value; }
        }


        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(this.Name).AppendLine("Company:");
            if (this.Company != null)
            {
                sb.AppendLine(this.Company.ToString());
            }
            sb.AppendLine("Car:");
            if (this.Car != null)
            {
                sb.AppendLine(this.Car.ToString());
            }
            sb.AppendLine("Pokemon:");
            if (this.Pokemons.Count != 0)
            {
                foreach(var item in this.Pokemons)
                {
                    sb.AppendLine(item.ToString());
                    
                }
            }
            sb.AppendLine("Parents:");
            if (this.Parents.Count != 0)
            {
                foreach (var item in this.Parents)
                {
                    sb.AppendLine(item.ToString());
                }
            }
            sb.AppendLine("Children:");
            if (this.Parents.Count != 0)
            {
                foreach (var item in this.Children)
                {
                    sb.Append(item.ToString());
                }
            }
            return sb.ToString().Trim();

        }



    }
}
