using System;
using System.Collections.Generic;
using System.Text;

namespace BorderControl
{
    public  class Citizen:IIdentifiable,IBirths
    {

        public string Name { get; set; }
        public int Age { get; set; }
        public string Id { get; set; }
        public string Birthdate { get; set; }

        public Citizen(string name,int age,string id)
        {
            Name = name;
            Age = age;
            Id = id;
           
        }
        public Citizen(string name, int age, string id,string birthdate)
            :this(name,age,id)
        {
            this.Birthdate = birthdate;
        }

        
    }
}
