using System;

namespace CustomRandomList
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            RandomList list = new RandomList();
            list.Add("First");
            list.Add("Second");
            list.Add("Third");
            list.Add("Fourth");
            list.Add("Fifth");
            Console.WriteLine(list.RandomString()); 
            
        }
    }
}
