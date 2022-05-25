using ExtensionMethod1;
using System;

namespace ExtensionMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            //Example 1
            var obj = new OldClass();
            obj.Test1();
            obj.Test2();

            //Calling exrension methods
            obj.Text3();
            obj.Text4(10);
            obj.Text5();

            NewClass.Text6(10);
            NewClass.Text5(obj);

            //Example 2
            int i = 10;
            bool result = i.IsGreaterThan(100);
            Console.WriteLine(result);

            Console.ReadLine();
        }
    }
}
