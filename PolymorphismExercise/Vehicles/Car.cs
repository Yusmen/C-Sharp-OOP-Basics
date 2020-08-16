using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public class Car : Vehicle
    {

        private const double airConditionConsumption = 0.9;

        public Car(double fuelquantity, double fuelconsumption, int tankcapacity) 
            : base(fuelquantity, fuelconsumption, tankcapacity)
        {
            this.FuelConsumption += airConditionConsumption;
        }
    }
}
