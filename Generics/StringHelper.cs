using System;

namespace Generics
{
    public class StringHelper
    {
        private string stringMember;
        
        public StringHelper(string data)
        {
            stringMember = data;
        }

        public void StringMethod()
        {
            Console.WriteLine("The stringMember is: {0}", stringMember);
        }        
    }
}
