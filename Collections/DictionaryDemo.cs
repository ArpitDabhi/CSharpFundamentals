using System;
using System.Collections.Generic;
using System.Linq;

namespace Collections
{
    public static class DictionaryDemo
    {
        public static void CreateDictionary()
        {
            Dictionary<int, string> numberNames = new Dictionary<int, string>();
            numberNames.Add(1, "One"); //adding key/value using the Add() method
            numberNames.Add(3, "Three");
            numberNames.Add(2, "Two");

            foreach (var item in numberNames)
                Console.WriteLine("Key: {0}, Value: {1}", item.Key, item.Value);

            //creating a dictionary using collection-initializer syntax
            var cities = new Dictionary<string, string>()
            {
                {"UK", "London, Manchester, Birmingham"},
                {"USA", "Chicago, New York, Washington"},
                {"India", "Mumbai, New Delhi, Pune"}
            };

            foreach (var kvp in cities)
                Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);

        }

        public static void AccessDictionaryElements()
        {
            var cities = new Dictionary<string, string>()
            {
                {"UK", "London, Manchester, Birmingham"},
                {"USA", "Chicago, New York, Washington"},
                {"India", "Mumbai, New Delhi, Pune"}
            };

            Console.WriteLine(cities["UK"]); //prints value of UK key
            Console.WriteLine(cities["USA"]);//prints value of USA key
                                             //Console.WriteLine(cities["France"]); // run-time exception: Key does not exist

            //use ContainsKey() to check for an unknown key
            if (cities.ContainsKey("France"))
            {
                Console.WriteLine(cities["France"]);
            }


            Console.WriteLine("---access elements using for loop---");
            //use ElementAt() to retrieve key-value pair using index
            for (int i = 0; i < cities.Count; i++)
            {
                Console.WriteLine("Key: {0}, Value: {1}",
                                                        cities.ElementAt(i).Key,
                                                        cities.ElementAt(i).Value);
            }
        }

        public static void RemoveDictionaryElements()
        {
            var cities = new Dictionary<string, string>()
            {
                {"UK", "London, Manchester, Birmingham"},
                {"USA", "Chicago, New York, Washington"},
                {"India", "Mumbai, New Delhi, Pune"}
            };

            Console.WriteLine("Total Elements: {0}", cities.Count);

            cities.Remove("UK"); // removes UK 
            //cities.Remove("France"); //throws run-time exception: KeyNotFoundException

            if (cities.ContainsKey("France"))
            { // check key before removing it
                cities.Remove("France");
            }

            Console.WriteLine("Total Elements: {0}", cities.Count);

            cities.Clear(); //deletes all elements

            Console.WriteLine("Total Elements after Clear(): {0}", cities.Count);
        }
    }
}
