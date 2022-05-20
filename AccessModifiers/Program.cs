using System;

namespace AccessModifiers
{
    public class Program : Protected
    {
        static void Main(string[] args)
        {
            var publicObj = new Public();
            // Accessing public variable  
            Console.WriteLine("Hello " + publicObj.name);
            // Accessing public function  
            publicObj.Msg("I am Public Method");

            //Protected
            Program program = new Program();
            //Accessing protected variable
            Console.WriteLine("Hello " + program.name);
            //Accessing protected function
            program.Msg("Swami Ayyer");

            ////Private
            //Private privateTest = new Private();
            //// Accessing private variable  
            //Console.WriteLine("Hello " + privateTest.name);
            //// Accessing private function  
            //privateTest.Msg("Peter Decosta");

            Console.ReadLine();
        }
    }
}
