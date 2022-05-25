using ExtensionMethod;
using System;

namespace ExtensionMethod1
{
    public static class NewClass
    {
        public static void Text3(this OldClass O)
        {
            Console.WriteLine("Method Three");
        }


        public static void Text4(this OldClass O, int x)
        {
            Console.WriteLine("Method Four: " + x);
        }

        public static void Text5(this OldClass O)
        {
            Console.WriteLine("Method Five: " + O.x);
        }

        public static void Text6(int x)
        {
            Console.WriteLine("Method Six: " + x);
        }
    }
}
