using System;

namespace Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            // creating object
            var obj = new DemoEncapsulation();

            // calls set accessor of the property Name, 
            // and pass "Jason" as value of the 
            // Name field 'value'
            obj.Name = "Jason";

            // calls set accessor of the property Age, 
            // and pass "21" as value of the 
            // Age field 'value'
            obj.Age = 21;

            // Displaying values of the variables
            Console.WriteLine("Name: " + obj.Name);
            Console.WriteLine("Age: " + obj.Age);
            Console.ReadLine();
        }
    }
}
