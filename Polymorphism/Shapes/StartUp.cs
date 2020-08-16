using System;

namespace Shapes
{
    public class StartUp
    {
        public static void Main(string[] args)
        {

            Shape rectangle = new Reactangle(5, 6);
            Shape circle = new Circle(10);

            Console.WriteLine(rectangle.CalculateArea());
            Console.WriteLine(rectangle.CalculatePerimeter());
            Console.WriteLine(circle.CalculatePerimeter());
            Console.WriteLine(circle.CalculateArea());
           
        }
    }
}
