using System;
using System.Collections.Generic;
using System.Text;

namespace SpeedRacing
{
    
    public class Car
    {
        private string model;
        private double fuelAmount;
        private double fuelConsumption;
        private int traveledDistance;

        public Car(string model,int fuelAmount,double fuelConsumption)
        {
            this.model = model;
            this.fuelAmount = fuelAmount;
            this.fuelConsumption = fuelConsumption;
            this.traveledDistance = 0;
        }
        public string Model
        {
            get { return this.model; }
            set { this.model = value; }
        }
        public double FuelAmount
        {
            get { return this.fuelAmount; }
            set { this.fuelAmount = value; }
        }
        public double FuelConsumption
        {
            get { return this.fuelConsumption; }
            set { this.fuelConsumption = value; }
        }
        public int TraveledDistance
        {
            get { return this.traveledDistance; }
            set { this.traveledDistance = value; }
        }
    }
}
