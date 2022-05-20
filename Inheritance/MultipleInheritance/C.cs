using System;

namespace Inheritance.MultipleInheritance
{
    public class C : InterfaceA, InterfaceB
    {
        private int a;
        private int b;

        public C(int x, int y)
        {
            a = x;
            b = y;
        }

        public void PutA()
        {
            Console.WriteLine("a = {0}", a);
        }

        public void PutB()
        {
            Console.WriteLine("b = {0}", b);
        }
    }
}