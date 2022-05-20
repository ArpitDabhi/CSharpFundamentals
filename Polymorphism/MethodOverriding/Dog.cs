using System;

namespace Polymorphism.MethodOverriding
{
    public class Dog : Animal
    {
        public override void Eat()
        {
            Console.WriteLine("Eating bread...");
        }
    }
}
