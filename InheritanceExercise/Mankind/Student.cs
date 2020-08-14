using System;
using System.Collections.Generic;
using System.Text;

namespace Mankind
{
   public class Student:Human
    {

        private string facultyNumber;


        public Student(string firstName, string lastName,string facultyNumber)
            :base(firstName,lastName)
        {
            this.FacultyNumber = facultyNumber;
        }

        public string FacultyNumber
        {
            get { return facultyNumber; }
            set
            {

                if (value.Length < 5 || value.Length > 10)
                {
                    throw new ArgumentException("Invalid faculty number!");
                 


                }
                facultyNumber = value;
            }
        }

        public override string ToString()
        {
            StringBuilder st = new StringBuilder();
            st.AppendLine($"First Name: {FirstName}");
            st.AppendLine($"Last Name: {LastName}");
            st.AppendLine($"Faculty number: {FacultyNumber}");
            st.AppendLine();
            return st.ToString();

        }

    }
}
