using System;

namespace VariablesAndConstants
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables

            // Naming Conventions
            //int var; // Valid
            //int _var; // Valid
            //int var1; // Valid
            //int name_var_1; // Valid
            //int 10; // Invalid
            //int 10val; // Invalid
            //int name var 1; // Invalid
            //int switch; // Invalid

            int a = 10;
            int b;
            b = 15;
            Console.WriteLine("Value of a is {0}", a);
            Console.WriteLine($"Value of b is {b}");


            // Constants

            const double pi = 3.14159;   // constant declaration 
            double r = 10;
            double area = pi * r * r;
            double circumference = 2 * pi * r;

            Console.WriteLine("Area of circle is: {0}", area);
            Console.WriteLine("Circumference of circle is: {0}", circumference);
            Console.ReadLine();
        }
    }
}
