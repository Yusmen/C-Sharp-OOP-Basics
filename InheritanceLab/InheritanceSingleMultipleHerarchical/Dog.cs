using System;
using System.Collections.Generic;
using System.Text;

namespace Farm
{
    public class Dog : Animal
    {

        public void Bark()
        {
            Console.WriteLine("barking");
        }

        public override void Eat()
        {
            Console.WriteLine("Dog eats bones");
        }
    }
}
