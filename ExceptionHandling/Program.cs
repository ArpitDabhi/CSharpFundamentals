using System;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            //WithoutTryCatch();
            //TryCatch();
            //TryCatchFinally();
            UserDefinedException();

            Console.ReadLine();
        }

        public static void WithoutTryCatch()
        {
            int a = 10;
            int b = 0;
            int x = a / b;
            Console.WriteLine("Rest of the code");
        }

        public static void TryCatch()
        {
            try
            {
                int c = 10;
                int d = 0;
                int f = c / d;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            Console.WriteLine("Rest of the code");
        }

        public static void TryCatchFinally()
        {
            try
            {
                int g = 10;
                int h = 0;
                int i = g / h;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                Console.WriteLine("Finally block is executed");
            }
            Console.WriteLine("Rest of the code");

        }

      

        public static void UserDefinedException()
        {
            try
            {
                Validate(12);
            }
            catch (InvalidAgeException e)
            {
                Console.WriteLine(e);
            }


            Console.WriteLine("Rest of the code");
        }

        public static void Validate(int age)
        {
            if (age < 18)
            {
                throw new InvalidAgeException("Sorry, Age must be greater than 18");
            }
        }
    }
}
