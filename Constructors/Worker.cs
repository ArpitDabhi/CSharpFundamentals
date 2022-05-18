using System;

namespace Constructors
{
    public class Worker
    {
        public int id;
        public string name;
        public float salary;
        
      
        public Worker(int i, string n, float s)
        {
            id = i;
            name = n;
            salary = s;
        }

        public void display()
        {
            Console.WriteLine($"{id} {name} {salary}");
        }
    }
}
