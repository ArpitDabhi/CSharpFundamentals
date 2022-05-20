using System;

namespace Abstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle c = new Circle(5.0);
            Console.WriteLine($"Area of Circle {c.Area()}");

            Square s = new Square(2.5);
            Console.WriteLine($"Area of Square = {s.Area()}");

            Triangle t = new Triangle(2.0, 5.0);
            Console.WriteLine($"Area of Triangle = {t.Area()}");

            Console.ReadLine();
        }
    }
}
