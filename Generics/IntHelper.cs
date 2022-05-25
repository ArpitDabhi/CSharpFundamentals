using System;

namespace Generics
{
    public class IntHelper
    {
        private int intMember;
        
        public IntHelper(int data)
        {
            intMember = data;
        }       

        public void IntMethod()
        {
            Console.WriteLine("The intMember is: {0}", intMember);
        }
    }
}
