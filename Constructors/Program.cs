using System;

namespace Constructors
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Default Constructor
            Employee e1 = new Employee();
            Employee e2 = new Employee();


            //Parameterized Constructor
            Worker worker1 = new Worker(101, "W1", 890000f);
            Worker worker2 = new Worker(102, "W2", 490000f);
            worker1.display();
            worker2.display();
            worker2.id = 103;
            worker2.display();

            Console.ReadLine();
        }
    }
}