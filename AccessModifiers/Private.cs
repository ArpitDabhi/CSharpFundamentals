using System;

namespace AccessModifiers
{
    public class Private
    {
        private string name = "I am Private field";
        private void Msg(string msg)
        {
            Console.WriteLine("Hello " + msg);
        }
    }
}
