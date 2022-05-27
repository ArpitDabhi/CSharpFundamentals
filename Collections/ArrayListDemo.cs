using System;
using System.Collections;

namespace Collections
{
    public static class ArrayListDemo
    {
        public static void AddingElementsInArrayList()
        {
            var arlist1 = new ArrayList();
            arlist1.Add(1);
            arlist1.Add("Bill");
            arlist1.Add(" ");
            arlist1.Add(true);
            arlist1.Add(4.5);
            arlist1.Add(null);

            Console.WriteLine("ArrayList 1 Elements");

            for (int i = 0; i < arlist1.Count; i++)
                Console.WriteLine(arlist1[i]);

            // adding elements using object initializer syntax
            var arlist2 = new ArrayList()
                    {
                        2, "Steve", true, 4.5, null
                    };


            Console.WriteLine("ArrayList 2 Elements");

            foreach (var item in arlist2)
            {
                Console.WriteLine(item);
            }
        }


        public static void AccessingAnArrayList()
        {
            var arlist = new ArrayList()
                {
                    1,
                    "Bill",
                    300,
                    4.5f
                };

            //Access individual item using indexer
            int firstElement = (int)arlist[0]; //returns 1
            string secondElement = (string)arlist[1]; //returns "Bill"
                                                      //int secondElement = (int) arlist[1]; //Error: cannot cover string to int

            //using var keyword without explicit casting
            var first = arlist[0]; //returns 1
            var second = arlist[1]; //returns "Bill"
            //var fifthElement = arlist[5]; //Error: Index out of range

            //update elements
            arlist[0] = "Steve";
            arlist[1] = 100;
            //arlist[5] = 500; //Error: Index out of range
        }

        public static void InsertRemoveFromArrayList()
        {
            ArrayList arlist = new ArrayList()
                {
                    1,
                    "Bill",
                    300,
                    4.5f
                };

            //arlist.Insert(1, "Second Item");
            arlist.Add("Second Item");

            foreach (var val in arlist)
                Console.WriteLine(val);

            arlist.Remove(null); //Removes first occurance of null
            arlist.RemoveAt(4); //Removes element at index 4
            arlist.RemoveRange(0, 2);//Removes two elements starting from 1st item (0 index)
        }
    }
}
