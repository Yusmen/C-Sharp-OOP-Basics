using System;
using System.Collections.Generic;
using System.Text;

namespace Mankind
{
    public class Worker:Human
    {

        private double weekSalary;
        private int workHoursPerDay;

        public Worker(string firstName, string lastName,double weekSalary,int workHoursPerDay)
            :base(firstName,lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        public int WorkHoursPerDay
        {
            get { return workHoursPerDay; }
            set
            {

                if (value < 1 || value > 12)
                {
                    throw new ArgumentException("Expected value mismatch! Argument: workHoursPerDay");
             
                }
                workHoursPerDay = value;
            }
        }


        public double WeekSalary
        {
            get { return weekSalary; }
            set
            {

                if (value < 10)
                {
                    throw new ArgumentException("Expected value mismatch! Argument: weekSalary");
                    
                }
                weekSalary = value;
            }
        }

        public override string ToString()
        {
            StringBuilder st = new StringBuilder();
            st.AppendLine($"First Name: {base.FirstName}");
            st.AppendLine($"Last Name: {base.LastName}");
            st.AppendLine($"Week Salary: {this.WeekSalary:f2}");
            st.AppendLine($"Hours per day: {this.WorkHoursPerDay:f2}");
            st.AppendLine($"Salary per hour: {(WeekSalary / 5) / WorkHoursPerDay:f2}");

            return st.ToString();


                
        }

    }
}
