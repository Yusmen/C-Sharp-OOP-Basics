using System;
using System.Collections.Generic;
using System.Text;

namespace Google
{

    
    class Parent
    {
        private string name;
        private string birthday;


        public Parent(string name,string birthday)
        {
            this.Name = name;
            this.Birthday = birthday;
        }

        public string Birthday
        {
            get { return birthday; }
            set { birthday = value; }
        }


        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public override string ToString()
        {
            return $"{ this.Name} {this.Birthday}";
        }

    }
}
