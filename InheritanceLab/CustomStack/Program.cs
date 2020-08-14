using System;

namespace CustomStack
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            StackOfStrings stack = new StackOfStrings();
            stack.Push("Pesho");
            stack.Push("PEsho");
            stack.Push("PEsho");

            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Peek());
            Console.WriteLine(stack.isEmpty());
            

           
                
        }
    }
}
