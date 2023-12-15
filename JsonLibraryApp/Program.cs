using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace JsonLibraryApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();

            //library.library.Add(new Book() 
            //{ 
            //    Title = "The Lord of the Rings", 
            //    Author = "J.R. Tolkien", 
            //    Genre = "Fantasy", 
            //    Year = 1963 });
            //library.library.Add(new Book()
            //{
            //    Title = "Scanner darkly",
            //    Author = "Philip Dick",
            //    Genre = "Drama",
            //    Year = 1969
            //});

            //library.SerializeBooks(library.library);

            List<Book> books = library.DeserializeBooks();

            foreach(Book item in books)
            {
                Console.WriteLine($"{item.Title}, {item.Author}, {item.Genre}, {item.Year}");
            }
        }
    }
}
