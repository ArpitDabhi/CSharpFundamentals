using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace AsyncAwait
{
    public static class Asynchronous
    {
        public static void AsynchronousProgramming()
        {
            var sw = new Stopwatch();
            sw.Start();

            Task.WaitAll(F1(), F2(), F3());

            sw.Stop();

            var elapsed = sw.ElapsedMilliseconds;
            Console.WriteLine($"elapsed: {elapsed} ms");
        }

        private static async Task F1()
        {            
            await Task.Delay(4000);
            Console.WriteLine("f1 called");
        }

        private static async Task F2()
        {
            await Task.Delay(7000);
            Console.WriteLine("f2 called");
        }

        private static async Task F3()
        {
            await Task.Delay(2000);
            Console.WriteLine("f3 called");
        }
    }
}
