using System;

namespace AsyncAwait
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("SynchronousProgramming");
            Synchronous.SynchronousProgramming();

            Console.WriteLine("----------------------------------");

            Console.WriteLine("AsynchronousProgramming");
            Asynchronous.AsynchronousProgramming();


            Console.ReadLine();
        }
    }
}