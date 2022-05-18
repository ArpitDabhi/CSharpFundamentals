using System;

namespace Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            //FIELD
            var person = new Person();
            person.setHeight(150);
            Console.WriteLine(person.getHeight());

            //Property
            person.Height = 200;
            Console.WriteLine(person.Height);


            var person1 = new Person(new DateTime(2000, 1, 1));
            Console.WriteLine(person1.Age);
            Console.ReadLine();
        }
    }
}
