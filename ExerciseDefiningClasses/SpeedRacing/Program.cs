using System;
using System.Collections.Generic;


namespace SpeedRacing
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());


            List<Car> cars = new List<Car>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                string model = input[0];
                int fuelAmount = int.Parse(input[1]);
                double fuelConsumption = double.Parse(input[2]);
                Car car = new Car(model,fuelAmount,fuelConsumption);
                cars.Add(car);

            }

            while (true)
            {

                string input = Console.ReadLine();
                if (input == "End")
                {
                    break;
                }

                string[] tokens = input.Split();
                string model = tokens[1];
                int amount = int.Parse(tokens[2]);

                foreach (var item in cars)
                {
                    
                    if (item.Model == model)
                    {
                        var multiplied = amount * item.FuelConsumption;
                        if (multiplied <= item.FuelAmount)
                        {
                            
                            item.FuelAmount -= multiplied;
                            item.TraveledDistance += amount;
                        }
                        else
                        {
                            Console.WriteLine("Insufficient fuel for the drive");
                        }
                        
                    }
                }
                        
            }
            foreach (var item in cars)
            {
                
                Console.WriteLine($"{item.Model} {item.FuelAmount:f2} {item.TraveledDistance}");
            }
                    


        }
    }
}
