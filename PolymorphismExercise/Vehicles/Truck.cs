using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public class Truck : Vehicle
    {

        private const double airConditionConsumption = 1.6;

        public Truck(double fuelquantity, double fuelconsumption, int tankcapacity) 
            : base(fuelquantity, fuelconsumption, tankcapacity)
        {
            this.FuelConsumption += airConditionConsumption;
        }
    }
}
