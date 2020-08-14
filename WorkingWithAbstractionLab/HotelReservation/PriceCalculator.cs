using System;
using System.Collections.Generic;
using System.Text;

namespace HotelReservation
{
    public static class PrceCalculator
    {

        public static double Calculate(double pricePerDay,
            int days,Seasons season,Discount discount)
        {
            return (pricePerDay * days * (int)season) * (1 - (double)discount / 100);
        }
        
    }
}
