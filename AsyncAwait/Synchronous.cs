using System;
using System.Diagnostics;
using System.Threading;

namespace AsyncAwait
{
    public static class Synchronous
    {
        public static void SynchronousProgramming()
        {
            var sw = new Stopwatch();
            sw.Start();

            F1();
            F2();
            F3();

            sw.Stop();

            var elapsed = sw.ElapsedMilliseconds;
            Console.WriteLine($"elapsed: {elapsed} ms");
        }

        private static void F1()
        {
            Console.WriteLine("f1 called");
            Thread.Sleep(4000);
        }

        private static void F2()
        {
            Console.WriteLine("f2 called");
            Thread.Sleep(7000);
        }

        private static void F3()
        {
            Console.WriteLine("f3 called");
            Thread.Sleep(2000);
        }
    }
}
