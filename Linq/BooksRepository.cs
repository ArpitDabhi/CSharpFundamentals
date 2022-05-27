using System.Collections.Generic;

namespace Linq
{
    public class BooksRepository
    {
        public IEnumerable<Book> GetBooks()
        {
            return new List<Book>() {
                new Book() { Title = "C# Basics", Price = 7 } ,
                new Book() { Title = "C# Intermediate", Price = 9 } ,
                new Book() { Title = "C# Advanced", Price = 12 } ,
                new Book() { Title = "Java", Price = 15 } ,
                new Book() { Title = "Web API", Price = 7 } ,
            };
        }
    }
}
