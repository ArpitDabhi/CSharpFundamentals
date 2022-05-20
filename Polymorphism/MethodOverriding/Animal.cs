using System;

namespace Polymorphism.MethodOverriding
{
    public class Animal
    {
        public virtual void Eat()
        {
            Console.WriteLine("Eating...");
        }
    }
}
