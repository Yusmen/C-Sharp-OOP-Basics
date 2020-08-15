using System;

namespace Telephony
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] numbers = Console.ReadLine().Split();
            string[] urls = Console.ReadLine().Split();
            Smarthphone smarthphone = new Smarthphone();

            for (int i = 0; i < numbers.Length; i++)
            {
                smarthphone.Call(numbers[i]);
            }

            for (int i = 0; i < urls.Length; i++)
            {
                smarthphone.Browse(urls[i]);
            }
        }
    }
}
