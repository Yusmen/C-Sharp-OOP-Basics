using System;

namespace Cars
{
    public class StartUP
    {
        public static void Main(string[] args)
        {

            var seat = new Seat("Leon", "Grey");
            var tesla = new Tesla("Model 3", "Red", 2);

            Console.WriteLine(seat.ToString());
            Console.WriteLine(tesla.ToString());

        }
    }
}
