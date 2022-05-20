using Inheritance.MultiLevelInheritance;
using Inheritance.MultipleInheritance;
using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            //Single Level Inheritance
            Console.WriteLine("Single Level Inheritance");
            var child = new Child1();
            Console.WriteLine($"Sum = {child.GetSum()}");
            Console.WriteLine(child.a);
            Console.WriteLine(child.b);

            Console.WriteLine("\n----------------------------------------------------\n");

            //Multi-Level Inheritance
            Console.WriteLine("Multi-Level Inheritance");
            Child4 child4 = new Child4();
            Child3 child3 = new Child3();
            Console.WriteLine("child4.a = {0}", child4.a);
            Console.WriteLine("child4.c3 = {0}", child4.c3);
            Console.WriteLine("child4.c4 = {0}", child4.c4);
            Console.WriteLine("child3.a = {0}", child3.a);
            Console.WriteLine("child3.c3 = {0}", child3.c3);

            Console.WriteLine("\n----------------------------------------------------\n");

            //Hierarchical Inheritance
            Console.WriteLine("Hierarchical Inheritance");
            Child1 obj1 = new Child1();
            Child2 obj2 = new Child2();

            Console.WriteLine("Using class Child1 object (obj1)");
            Console.WriteLine("a = {0}", obj1.a);
            Console.WriteLine("b = {0}", obj1.b);

            Console.WriteLine("Using class Child2 object (obj2)");
            Console.WriteLine("a = {0}", obj2.a);
            Console.WriteLine("c = {0}", obj2.c);

          


            Console.WriteLine("\n----------------------------------------------------\n");

            //Multiple Inheritance
            Console.WriteLine("Multiple Inheritance");
            C cObj = new C(17, 4);
            cObj.PutA();
            cObj.PutB();
            Console.ReadLine();
        }
    }
}