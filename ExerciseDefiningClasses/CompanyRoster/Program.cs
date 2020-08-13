using System;
using System.Collections.Generic;
using System.Linq;

namespace CompanyRoster
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var workers = new List<Employee>();
            var  highestSalaries = new Dictionary<string, List<double>>();
            
            for (int i = 0; i < n; i++)   
            {
                
                string[] input = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);
                string name = input[0];
                double salary = double.Parse(input[1]);
                string position = input[2];
                string department = input[3];
                var emp = new Employee(name, salary, position, department);
                workers.Add(emp);
                if (!highestSalaries.ContainsKey(department))
                {
                    highestSalaries[department] = new List<double>();
                }
                highestSalaries[department].Add(salary);
                if (input.Length == 5)
                {
                    var isNumeric = int.TryParse(input[4], out int m);
                    if (isNumeric)
                    {
                        emp.Age = m;
                    }
                    else
                    {
                        emp.Email = input[4];
                    }
                }
                else if (input.Length == 6)
                {
                    emp.Age = int.Parse(input[5]);
                    emp.Email = input[4];

                }
                 
 

            }
            foreach (var kvp in highestSalaries)
            {
               kvp.Value[0]= kvp.Value.Average();
            }
            highestSalaries = highestSalaries.OrderByDescending(x => x.Value[0])
                .ToDictionary(x => x.Key, x => x.Value);
            string highestDepertment = string.Empty;


            foreach (var kvp in highestSalaries)
            {
                highestDepertment = kvp.Key;
                break;
            }
            workers = workers.Where(x => x.Department == highestDepertment)
                .OrderByDescending(x=>x.Salary).ToList();
            Console.WriteLine();
            Console.WriteLine($"Highest Average Salary: {highestDepertment}");
            foreach(var item in workers)
            {
                Console.WriteLine($"{item.Name} " +
                    $"{item.Salary:f2} {item.Email} {item.Age}");
                
            }
            


        }
    }
}
