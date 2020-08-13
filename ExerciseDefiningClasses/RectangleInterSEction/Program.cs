using System;
using System.Collections.Generic;
using System.Linq;

namespace RectangleInterSEction
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] oparations = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int n = oparations[0];
            int m = oparations[1];

            List<Rectangle> rectangles = new List<Rectangle>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                string id = input[0];
                double width= double.Parse(input[1]);
                double height = double.Parse(input[2]);
                double x = double.Parse(input[3]);
                double y = double.Parse(input[4]);
                var rct = new Rectangle(id, width, height, x, y);
                rectangles.Add(rct);

            }
            for (int i = 0; i < m; i++) 
            {
                string[] input = Console.ReadLine().Split();

                string firstId = input[0];
                string secondId = input[1];

                Rectangle firstRectangle = rectangles.FirstOrDefault(x => x.Id == firstId);
                Rectangle secondRectangle = rectangles.FirstOrDefault(x => x.Id == secondId);

                if (firstRectangle.Intersect(secondRectangle))
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }


            }
        }
    }
}
