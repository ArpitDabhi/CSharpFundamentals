using System;
using System.Collections.Generic;

namespace Collections
{
    public static class ListDemo
    {
        public static void AddingElementsToList()
        {
            var primeNumbers = new List<int>();
            primeNumbers.Add(1);
            primeNumbers.Add(3);
            primeNumbers.Add(5);
            primeNumbers.Add(7);

            foreach (var item in primeNumbers)
            {
                Console.WriteLine(item);
            }

            var cities = new List<string>();
            cities.Add("New York");
            cities.Add("London");
            cities.Add("Mumbai");
            cities.Add("Chicago");
            cities.Add(null); // null is allowed

            Console.WriteLine("No of cities: " + cities.Count);
            foreach (var item in cities)
            {
                Console.WriteLine(item);
            }

            // adding elements using collection initializer syntax
            var bigCities = new List<string>() { "New York", "London", "Mumbai", "Chicago" };

            Console.WriteLine("No of bigCities: " + bigCities.Count);
            foreach (var item in bigCities)
            {
                Console.WriteLine(item);
            }

            var students = new List<Student>() {
                new Student(){ Id = 1, Name="Bill"},
                new Student(){ Id = 2, Name="Steve"},
                new Student(){ Id = 3, Name="Ram"},
                new Student(){ Id = 4, Name="Abdul"}
            };

            students.Add(new Student() { Id = 5, Name = "Josh" });

            Console.WriteLine("No of students: " + students.Count);
            foreach (var item in students)
            {
                Console.WriteLine($"{item.Id} {item.Name}");
            }
        }

        public static void RemovingElementsFromList()
        {
            var numbers = new List<int>() { 10, 20, 30, 40, 10 };
            numbers.Remove(10); // removes 10 elements from a list
            numbers.RemoveAt(2); //removes the 3rd element (index starts from 0)

            //numbers.RemoveAt(10); //Will throw exception

            foreach (var num in numbers)
                Console.WriteLine(num);
        }
    }

    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
