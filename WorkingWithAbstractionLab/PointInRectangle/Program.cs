using System.Collections.Generic;
using System;
using System.Linq;

namespace PointInRectangle

{
    class Program
    {
        static void Main(string[] args)
        {
            int[] coordinates = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();



            Rectangle rectangle = new Rectangle()
            {
                UpperLeftCorner = new Point(coordinates[0], coordinates[1]),
                LowerRightCorner = new Point(coordinates[2], coordinates[3])

            };
 

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int[] points = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();
                
                
                Console.WriteLine(rectangle.Contains(new Point(points[0],points[1])));

            }
                
            
        }
    }
}
