using System;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            ArithmeticOperators();
            RelationalOperators();
            LogicalOperators();
            AssignmentOperators();
            Console.ReadLine();
        }

        public static void ArithmeticOperators()
        {
            int a, b;
            a = 10;
            b = 5;
            Console.WriteLine("Arithmetic Operators in C#\n");
            Console.WriteLine("Value of a: {0} ", a);
            Console.WriteLine("Value of b: {0} \n", b);
            // performing operations
            Console.WriteLine("Addition of a and b: {0} ", a + b);
            Console.WriteLine("Subtraction of a and b: {0} ", a - b);
            Console.WriteLine("Multiplication of a and b: {0} ", a * b);
            Console.WriteLine("Division of a and b: {0} ", a / b);
            Console.WriteLine("Modulus of a and b: {0} ", a % b);
            Console.WriteLine("Increment of a: {0} ", ++a);
            Console.WriteLine("Decrement of b: {0} ", --b);

        }

        public static void RelationalOperators()
        {
            int a, b;
            a = 5;
            b = 10;
            Console.WriteLine("Relational Operators in C#\n");
          
            if (a == b)
                Console.WriteLine("{0} and {1} are equal", a, b);
            else if (a != b)
                Console.WriteLine("{0} and {1} are not equal", a, b);
            
            if (a > b)
                Console.WriteLine("{0} is greater than {1}", a, b);
            else if (a < b)
                Console.WriteLine("{0} is less than {1}", a, b);
            
            if (a >= b)
                Console.WriteLine("{0} is greater than or equal to {1}", a, b);
            else if (a <= b)
                Console.WriteLine("{0} is less than or equal to {1}", a, b);
        }

        public static void LogicalOperators()
        {
            int a = 5, b = 10, c = 1, d = 0;
            bool val = true;
            Console.WriteLine("Logical Operators in C#\n");
           
            if ((a > b) && (c > d))
                Console.WriteLine("{0} is greater than {1} and {2} is greater than {3}", a, b, c, d);
            
            if ((a > b) || (c > d))
                Console.WriteLine("{0} is greater than {1} or {2} is greater than {3}", a, b, c, d);
            
            if (!val)
                Console.WriteLine("Value of d is false");
            else
                Console.WriteLine("Value of d is true");
        }

        public static void AssignmentOperators()
        {
            int a = 10, b = 4;
            Console.WriteLine("Assignment Operators in C#\n");

            a += b;
            Console.WriteLine("Value of a is {0}", a);

            a -= b;
            Console.WriteLine("Value of a is {0}", a);

            a *= b;
            Console.WriteLine("Value of a is {0}", a);

            a /= b;
            Console.WriteLine("Value of a is {0}", a);

            a %= b;
            Console.WriteLine("Value of a is {0}", a);
        }
    }
}
