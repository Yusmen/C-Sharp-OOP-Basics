using System;

namespace Farm
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            Puppy puppy = new Puppy();
            Animal animal = new Animal();


            animal.Eat();
            dog.Eat();
            
        }
    }
}
