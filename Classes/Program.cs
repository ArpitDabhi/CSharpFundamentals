using System;

namespace Classes
{
    public class Person
    {
        public string name;

        public void Introduce(string to)
        {
            Console.WriteLine($"Hi {to}, I am {name}");
        }

        public static Person Parse(string name)
        {
            var person = new Person();
            person.name = name;

            return person;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();
            person.name = "Mark";
            person.Introduce("John");
            
            var person1 = Person.Parse("Chris");
            person1.Introduce("Josh");

            Console.ReadLine();
        }
    }
}
