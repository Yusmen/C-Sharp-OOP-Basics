using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
     public  interface IVehicle
    {

        double FuelQuantity { get; set; }


         double FuelConsumption { get; set; }
        int  TankCapacity { get; set; }

        void Drive(double distance);

        void Refuel(double fuel);
    }
}
