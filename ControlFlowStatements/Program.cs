using System;

namespace ControlFlowStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            //if statement
            int a = 5;
            if (a == 5)
                Console.WriteLine("Value of a is 5");


            //if...else statement
            int x = 10;
            if (x == 5)
                Console.WriteLine("Value of x is 5");
            else
                Console.WriteLine("Value of x is not 5");


            //switch statement

            char grade = 'A';
            Console.WriteLine("The grade you obtained is {0} ", grade);
            switch (grade)
            {
                case 'A':
                    Console.WriteLine("Wonderful!!");
                    break;
                case 'B':
                    Console.WriteLine("Good Enough");
                    break;
                case 'C':
                    Console.WriteLine("Perform Better");
                    break;
                case 'D':
                    Console.WriteLine("Not good enough");
                    break;
                case 'E':
                    Console.WriteLine("You Failed");
                    break;
                default:
                    Console.WriteLine("Invalid Choice");
                    break;
            }


            Console.ReadLine();
        }
    }
}
