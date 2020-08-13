using System;
using System.Collections.Generic;
using System.Linq;

namespace RawData
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
                int engineSpeed = int.Parse(input[1]);
                int enginePower = int.Parse(input[2]);
                int cargoWeight = int.Parse(input[3]);
                string cargoType = input[4];
                List<Tyre> tyres = new List<Tyre>();

                for (int j = 5; j < 12; j += 2) 
                {
                    double tyrePressure = double.Parse(input[j]);
                    int tyreAge = int.Parse(input[j + 1]);
                    var tyre = new Tyre(tyrePressure, tyreAge);
                    tyres.Add(tyre);
                }
                var engine = new Engine(engineSpeed, enginePower);
                var cargo = new Cargo(cargoWeight, cargoType);
                var car = new Car(model, engine, cargo, tyres);
                cars.Add(car);
              
            }
            string typeCargo = Console.ReadLine();

            if (typeCargo == "fragile")
            {
                cars = cars.Where(x => x.Cargo.Type
                == typeCargo && x.Tyres.Any(s => s.Pressure < 1)).ToList();
              
            }
            else
            {
                cars = cars.Where(x =>
                x.Cargo.Type == typeCargo && x.Engine.Power > 250).ToList();
            }

            foreach (var car in cars)
            {
                Console.WriteLine(car.Model);
            }
           
        }
    }
}
