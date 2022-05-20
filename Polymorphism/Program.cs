using Polymorphism.MethodOverloading;
using Polymorphism.MethodOverriding;
using System;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            //C# Method Overloading Example: By changing no. of arguments
            Console.WriteLine(Calculator.Add(12, 23));
            Console.WriteLine(Calculator.Add(12, 23, 25));

            //C# Method Overloading Example: By changing data type of arguments
            Console.WriteLine(Calculator.Add(12, 23));
            Console.WriteLine(Calculator.Add(12.4f, 21.3f));

            //C# Method Overriding Example

            Animal animal = new Animal();
            animal.Eat();

            Dog d = new Dog();
            d.Eat();

            Console.ReadLine();
        }
    }
}
