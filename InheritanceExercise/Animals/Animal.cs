using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public class Animal
    {

        private string name;
        private int age;
        private string gender;


        public Animal(string name,int age,string gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }
        public Animal(string name,int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Gender
        {
            get { return gender; }
            set
            {
                if (value.ToLower() != "male" && value.ToLower() != "female")
                {
                    throw new Exception("Invalid input!");
                  
                }
                gender = value;
            }
        }


        public int Age
        {
            get { return age; }
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Invalid input!");
               
                }
                age = value;

            }
        }


        public string Name
        {
            get { return name; }
            set
            {
                if (value == null || string.IsNullOrEmpty(value)) 
                {
                    throw new Exception("Invalid input!");

                }
                name = value;
            }
        }

    }
}
