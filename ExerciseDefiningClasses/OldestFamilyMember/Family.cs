using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DefiningClasses
{
    public class Family
    {

        private List<Person> people;

        public Family()
        {
            this.people = new List<Person>();
        }

        public List<Person> People
        {

            get { return this.people; }
            set { this.people = value; }
        }

        public void AddMember(Person member)
        {

            if (member == null)
            {
                throw new Exception();

            }
            this.People.Add(member);
        }

        public List<Person> GetOldestMember()
        {
            return this.People.Where(x=>x.Age>30).OrderBy(x=>x.Name).ToList();
        }
        
    }
}
