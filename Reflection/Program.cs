using System;
using System.Reflection;

namespace Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            //Example 1
            //In the code given below, we load the type t as a string using the typeof method. Then we apply reflection on t to find any information about string class, like its name, fullname, namespace, and basetype.

            // Initialise t as typeof string
            Type t = typeof(string);

            // Use Reflection to find about
            // any sort of data related to t
            Console.WriteLine("Name : {0}", t.Name);
            Console.WriteLine("Full Name : {0}", t.FullName);
            Console.WriteLine("Namespace : {0}", t.Namespace);
            Console.WriteLine("Base Type : {0}", t.BaseType);


            //Example 2
            //In this code, we use reflection to show all the metadata related to the program which includes classes, methods of these classes and the parameters associated with these parameters.

            // Declare Instance of class Assembly
            // Call the GetExecutingAssembly method
            // to load the current assembly
            Assembly executing = Assembly.GetExecutingAssembly();

            // Array to store types of the assembly
            Type[] types = executing.GetTypes();
            foreach (var item in types)
            {
                // Display each type
                Console.WriteLine("Class : {0}", item.Name);

                // Array to store methods
                MethodInfo[] methods = item.GetMethods();
                foreach (var method in methods)
                {
                    // Display each method
                    Console.WriteLine("--> Method : {0}", method.Name);

                    // Array to store parameters
                    ParameterInfo[] parameters = method.GetParameters();
                    foreach (var arg in parameters)
                    {
                        // Display each parameter
                        Console.WriteLine("----> Parameter : {0} Type : {1}",
                                                arg.Name, arg.ParameterType);
                    }
                }
            }

            Console.ReadLine();
        }
    }
}

