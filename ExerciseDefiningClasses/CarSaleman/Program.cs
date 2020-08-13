using System;
using System.Collections.Generic;


namespace CarSaleman
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Engine> engines = new List<Engine>();

            for (int i = 0; i < n; i++) 
            {

                string[] input = Console.ReadLine().Split(' ');
                string model = input[0];
                string power = input[1];

                
               var engine = new Engine(model, power);
                
                if (input.Length == 3)
                {
                    int x = 0;
                    bool isInteger = int.TryParse(input[2], out x);
                    if (isInteger)
                    {
                        engine.Displacement = input[2];
                    }
                    else
                    {
                        engine.Efficiency = input[2];
                    }
                }
                else if (input.Length == 4)
                {
                    engine.Displacement = input[2];
                    engine.Efficiency = input[3];
                }
                
                engines.Add(engine);
                    


            }
            int m = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();
            for (int i = 0; i < m; i++)
            { 
       
                string[] input = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries) ;
                string model = input[0];
                string engine = input[1];
                var car = new Car();
                car.Model = model;


                foreach (var eng in engines)
                {
                    if (eng.Model == engine)
                    {
 
                        car.Engine = eng;
                        break;
                    }
                }
                if (input.Length == 3)
                {
                    int z = 0;

                    bool isInteger = int.TryParse(input[2], out z);
                    if (isInteger)
                    {
                        car.Weight = z;
                    }
                    else
                    {
                        car.Color = input[2];
                    }
                }
                else if (input.Length == 4)
                {
                    car.Weight = int.Parse(input[2]);
                    car.Color = input[3];
                }
                cars.Add(car);

            }
            Console.WriteLine();
            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Model}:");
                Console.WriteLine($"   {car.Engine.Model}: ");
                Console.WriteLine($"         Power: {car.Engine.Power} ");
                Console.WriteLine($"         Displacement: {car.Engine.Displacement} ");
                Console.WriteLine($"         Efficinecy: {car.Engine.Efficiency} ");
                if (car.Weight == 0) 
                {
                    Console.WriteLine($"  Weight: n/a");
                }
                else
                {
                    Console.WriteLine($"  Weight: {car.Weight}");
                }
               
                Console.WriteLine($"  Color: {car.Color}");


            }

         
        }
    }
}
