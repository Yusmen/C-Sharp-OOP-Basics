using System;
using System.Collections.Generic;
using System.Text;

namespace CustomRandomList
{
   public  class RandomList:List<string>
    {

        public Random randomGenerator { get; set; }


        public RandomList()
        {
            this.randomGenerator = new Random();
        }

        public string RandomString()
        {
            var index = randomGenerator.Next(0, Count - 1);
            string result = this[index];
            this.RemoveAt(index);
            return result;
        }

    }
}
