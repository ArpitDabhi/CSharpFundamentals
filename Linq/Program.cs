using System.Collections.Generic;
using System.Linq;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            var books = new BooksRepository().GetBooks().ToList();
            //WithoutLinq(books);
            //LinqWhere(books);
            //LinqOrderBy(books);
            //LinqOrderByDescending(books);
            //LinqSelect(books);
            //LinqMethodChaining(books);
            LinqAggregation(books);

            System.Console.ReadLine();
        }

        public static void WithoutLinq(List<Book> books)
        {
            System.Console.WriteLine("Without LINQ");
            var cheapBooks = new List<Book>();

            foreach (var book in books)
            {
                if (book.Price < 10)
                    cheapBooks.Add(book);
            }

            foreach (var item in cheapBooks)
            {
                System.Console.WriteLine($"{item.Title} {item.Price}");
            }
        }

        public static void LinqWhere(List<Book> books)
        {
            System.Console.WriteLine("--------------------------------");
            System.Console.WriteLine("With LINQ");

            var cheapBooks1 = books.Where(book => book.Price < 10).ToList();

            foreach (var item in cheapBooks1)
            {
                System.Console.WriteLine($"{item.Title} {item.Price}");
            }
        }

        public static void LinqOrderBy(List<Book> books)
        {
            System.Console.WriteLine("--------------------------------");
            System.Console.WriteLine("Order By Asc Title");

            var orderByTitle = books.OrderBy(x => x.Title);

            foreach (var item in orderByTitle)
            {
                System.Console.WriteLine($"{item.Title} {item.Price}");
            }
        }

        public static void LinqOrderByDescending(List<Book> books)
        {
            System.Console.WriteLine("--------------------------------");
            System.Console.WriteLine("Order By Desc Price");

            var orderByPrice = books.OrderByDescending(x => x.Price);

            foreach (var item in orderByPrice)
            {
                System.Console.WriteLine($"{item.Title} {item.Price}");
            }
        }

        public static void LinqSelect(List<Book> books)
        {
            System.Console.WriteLine("--------------------------------");
            System.Console.WriteLine("Select Price");

            var selectPrice = books.Select(x => x.Price);

            foreach (var item in selectPrice)
            {
                System.Console.WriteLine($"{item}");
            }
        }

        public static void LinqMethodChaining(List<Book> books)
        {
            System.Console.WriteLine("--------------------------------");
            System.Console.WriteLine("Method chaining");

            var cheapBooks2 = books
                                    .Where(book => book.Price < 10)
                                    .OrderBy(x => x.Title)
                                    .Select(x => x.Title);

            foreach (var item in cheapBooks2)
            {
                System.Console.WriteLine($"{item}");
            }
        }

        public static void LinqAggregation(List<Book> books)
        {
            System.Console.WriteLine("--------------------------------");
            System.Console.WriteLine("Linq Aggregation");

            var sumPrice = books.Sum(book => book.Price);
            System.Console.WriteLine("Total Price of all books: " + sumPrice);

            var maxPrice = books.Max(book => book.Price);
            System.Console.WriteLine("Max Price: " + maxPrice);

            var minPrice = books.Min(book => book.Price);
            System.Console.WriteLine("Min Price: " + minPrice);
        }
    }
}
