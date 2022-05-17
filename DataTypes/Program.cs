using System;

namespace DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintValueDataTypes();
        }

        public static void PrintValueDataTypes()
        {
            bool boolVar = true; // bool
            byte byteVar = 255; // byte
            short shortVar = -66; // short
            ushort ushortVar = 66; // unsigned short
            int intVar = -1000; // integer
            uint uintVar = 1000; // unsigned int
            long longVar = -56000; // long
            ulong ulongVar = 56000; // Unsigned long
            float floatVar = 3.7330645f; // float

            double doubleVar = 13782.57543D; // double
            char charVar = 'A'; // character
            Console.WriteLine("Value Data Types in C#");
            Console.WriteLine(boolVar);
            Console.WriteLine(byteVar);
            Console.WriteLine(shortVar);
            Console.WriteLine(ushortVar);
            Console.WriteLine(intVar);
            Console.WriteLine(uintVar);
            Console.WriteLine(longVar);
            Console.WriteLine(ulongVar);
            Console.WriteLine(floatVar);
            Console.WriteLine(doubleVar);
            Console.WriteLine(charVar);
            Console.ReadLine();
        }
    }
}
