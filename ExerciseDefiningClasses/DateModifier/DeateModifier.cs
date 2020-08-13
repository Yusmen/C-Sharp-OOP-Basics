using System;
using System.Collections.Generic;
using System.Text;

namespace DateModifier
{
    public class DateModifier
    {

        private string firstDate;
        private string secondDate;

        public DateModifier()
        {
            this.firstDate = string.Empty;
            this.secondDate = string.Empty;
        }
        public string FirstDate
        {
            get
            {
                return this.firstDate;
            }
            set
            {
                firstDate = value;
            }
        }
        public string SecondDate
        {

            get
            {
                return this.secondDate;
            }
            set
            {
                this.secondDate = value;
            }

        }
        public int GetDays()
        {
          
            string[] first = firstDate.Split();
            int firstYear = int.Parse(first[0]);
            int firstMonth = int.Parse(first[1]);
            int firstDay = int.Parse(first[2]);
            DateTime d = new DateTime(firstYear, firstMonth, firstDay);
            string[] second = secondDate.Split();
            int secondYear = int.Parse(second[0]);
            int secondMonth = int.Parse(second[1]);
            int secondDay = int.Parse(second[2]);
            DateTime d1 = new DateTime(secondYear, secondMonth, secondDay);
            TimeSpan difference = d - d1;
            return Math.Abs(difference.Days);


        }




    }
}
