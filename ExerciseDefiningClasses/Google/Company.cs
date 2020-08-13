using System;
using System.Collections.Generic;
using System.Text;

namespace Google
{
    class Company
    {
        
        private string name;
        private string departmnet;
        private double salary;
        public Company(string name,string department,double salary )
        {
            this.Name = name;
            this.Department = department;
            this.Salary = salary;

        }

        public double Salary
        {
            get { return salary; }
            set { salary = value; }
        }


        public string Department
        {
            get { return departmnet; }
            set { departmnet = value; }
        }


        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public override string ToString()
        {
            return $"{this.Name} {this.Department} {this.Salary:f2}";
        }


    }
}
