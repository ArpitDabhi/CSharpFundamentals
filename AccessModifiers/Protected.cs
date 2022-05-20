using System;

namespace AccessModifiers
{
    public class Protected
    {
        protected string name = "I am Protected field";
        protected void Msg(string msg)
        {
            Console.WriteLine("Hello " + msg);
        }
    }
}
