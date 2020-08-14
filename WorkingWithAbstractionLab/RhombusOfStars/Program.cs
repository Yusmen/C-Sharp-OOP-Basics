using System;

namespace RhombusOfStars
{
    public class Program
    {

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++) 
            {
                PrintRow(n, i);
            }


            for (int i = n - 1; i >= 1; i--) 
            {
                PrintRow(n, i);
            }
        }

        private static void PrintRow(int size, int x)
        {
            for (int i = 0; i < size - x; i++) 
            {
                Console.Write(" ");
            }
            for (int col = 1; col < x; col++)
            {
                Console.Write("* ");

            }
            Console.WriteLine("* ");
                

        }
    }
}
