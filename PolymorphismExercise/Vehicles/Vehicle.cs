using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public abstract class Vehicle :IVehicle
    {

        private  double fuelConsumption;
        private  double fuelQuantity;
        private int tankCapacity;



        public Vehicle(double fuelquantity,double fuelconsumption,int tankcapacity)
        {
            
            this.FuelQuantity = fuelquantity;
            this.FuelConsumption = fuelconsumption;
            this.TankCapacity = tankcapacity;
        }
        public int TankCapacity
        {
            get { return tankCapacity; }
            set
            {
                if (value > TankCapacity)
                {
                    value = 0;
                }
                tankCapacity = value;
            }
        }

        public double FuelQuantity
        {
            get { return fuelQuantity; }
            set { fuelQuantity = value; }
        }


        public double FuelConsumption
        {
            get { return fuelConsumption; }
            set { fuelConsumption = value; }
        }

      

        public void Drive(double distance)
        {
           
            if (this.FuelQuantity >= distance * this.FuelConsumption)
            {
                FuelQuantity -= distance * this.FuelConsumption;
                Console.WriteLine($"{this.GetType().Name} travelled {distance} km");
            
            }
            else
            {
                throw new ArgumentException($"{this.GetType().Name} needs refueling");
            }
                    
        }

        public void Refuel(double fuel)
        {
            if (fuel < 0 || fuel == 0)
            {
                throw new ArgumentException($"Fuel must be a positive number");
            }
            if (fuel > FuelQuantity)
            {
                throw new ArgumentException($"Cannot fit {fuel } fuel in the tank");
            }
            if (this is Truck)
            {
                fuel *= 0.95;
            }
           

            this.FuelQuantity += fuel;
        }


        public override string ToString()
        {
            return $"{this.GetType().Name}: {this.FuelQuantity:f2}";
        }
    }
}
