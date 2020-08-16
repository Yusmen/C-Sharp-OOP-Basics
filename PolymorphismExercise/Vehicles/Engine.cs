using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
     public class Engine
    {


        public void Run()
        {
            string[] carInfo = Console.ReadLine().Split();
            string[] truckInfo = Console.ReadLine().Split();
            string[] busInfo = Console.ReadLine().Split();

            double carFuelConsumption = double.Parse(carInfo[2]);
            double carFuelQuantity = double.Parse(carInfo[1]);
            int carTankCapacity = int.Parse(carInfo[3]);

            double truckFuelConsumption = double.Parse(truckInfo[2]);
            double truckFuelQuantity = double.Parse(truckInfo[1]);
            int truckTankCapacity = int.Parse(truckInfo[3]);
             double busFuelConsumption = double.Parse(busInfo[2]);
            double busFuelQuantity = double.Parse(busInfo[1]);
            int busTankCapacity = int.Parse(busInfo[3]);

            Vehicle car = new Car(carFuelQuantity, carFuelConsumption,carTankCapacity);
            Vehicle truck = new Truck(truckFuelQuantity, truckFuelConsumption,truckTankCapacity);
            Bus bus = new Bus(busFuelQuantity, busFuelConsumption,busTankCapacity);

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                string command = input[0];
                string vehicle = input[1];
                try
                {

                    if (command == "Drive")
                    {
                        if (vehicle == "Car")
                        {
                            car.Drive(double.Parse(input[2]));
                        }
                        else if (vehicle == "Truck")
                        {
                            truck.Drive(double.Parse(input[2]));
                        }
                        else if (vehicle == "Bus")
                        {
                            bus.DriveWithPeople(double.Parse(input[2]));
                        }
                    }
                    else if (command == "Refuel")
                    {
                        if (vehicle == "Car")
                        {
                            car.Refuel(double.Parse(input[2]));
                        }
                        else if (vehicle == "Truck")
                        {
                            truck.Refuel(double.Parse(input[2]));
                        }
                        else if (vehicle == "Bus")
                        {
                            bus.Refuel(double.Parse(input[2]));
                        }
                    }
                    else if (command == "DriveEmpty")
                    {
                        bus.Drive(double.Parse(input[2]));
                    }

                }
                catch (ArgumentException ex)
                {

                    Console.WriteLine(ex.Message);
                }
               
            

            }
            Console.WriteLine(car);
            Console.WriteLine(truck);
            Console.WriteLine(bus);

        }
    }
}
