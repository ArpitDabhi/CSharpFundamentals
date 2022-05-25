using System;

namespace Generics
{
    public class GenericClass<T>
    {
        private T genericMember;

        public GenericClass(T data)
        {
            genericMember = data;
        }
     
        public void GenericMethod()
        {
            Console.WriteLine("The genericMember is: {0}", genericMember);
        }
    }
}
