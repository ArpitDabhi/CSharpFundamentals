using System;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            IntHelper intHelper = new IntHelper(10);
            intHelper.IntMethod();

            StringHelper stringHelper = new StringHelper("TestData");
            stringHelper.StringMethod();

            GenericClass<int> intGenericClass = new GenericClass<int>(10);
            intGenericClass.GenericMethod();

            GenericClass<string> stringGenericClass = new GenericClass<string>("TestData");
            stringGenericClass.GenericMethod();

            GenericClass<char> genericClass = new GenericClass<char>('A');
            genericClass.GenericMethod();

            Console.ReadLine();
        }
    }
}
