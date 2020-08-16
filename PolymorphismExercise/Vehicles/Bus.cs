using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public class Bus : Vehicle
    {
        private const double airConditionConsumption = 1.4;

        public Bus(double fuelquantity, double fuelconsumption, int tankcapacity) 
            : base(fuelquantity, fuelconsumption, tankcapacity)
        {
        }

        public void DriveWithPeople(double distance)
        {
            double currentConsumption = this.FuelConsumption;
            currentConsumption += 1.4;
            if (this.FuelQuantity >= distance * currentConsumption)
            {
                FuelQuantity -= distance * currentConsumption;
                Console.WriteLine($"{this.GetType().Name} travelled {distance} km");

            }
            else
            {
                throw new ArgumentException($"{this.GetType().Name} needs refueling");
            }
        }
    }
}
