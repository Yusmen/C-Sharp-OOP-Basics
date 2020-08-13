using System;

namespace DateModifier
{
    class Program
    {
        static void Main(string[] args)
        {
            string date = Console.ReadLine();
            string date1 = Console.ReadLine();
            DateModifier dt = new DateModifier();
            dt.FirstDate = date;
            dt.SecondDate = date1;
            Console.WriteLine(dt.GetDays());
           

        }
    }
}
