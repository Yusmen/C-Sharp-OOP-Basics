using System;

namespace HotelReservation
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine(PrceCalculator.Calculate(50.25, 5, Seasons.Summer, Discount.VIP));
            
       
        }
    }
}
