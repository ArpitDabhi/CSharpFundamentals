using System;

namespace AccessModifiers
{
    public class Public
    {
        public string name = "I am Public field";
        public void Msg(string msg)
        {
            Console.WriteLine("Hello " + msg);
        }
    }
}
