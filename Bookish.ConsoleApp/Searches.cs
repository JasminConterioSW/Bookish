using System;
using Bookish.DataAccess.Clients;

namespace Bookish.ConsoleApp
{
    public class Searches
    {
        public void PrintAllBooks()
        {
            var dbClient = new QueryDb();
            var allBooks = dbClient.GetAllBooks();

            foreach (var book in allBooks)
            {
                Console.WriteLine(book.Title);
            }
            
        }

        public void PrintAllUniqueBooks()
        {
            var dbClient = new QueryDb();
            var allBooks = dbClient.GetAllUniqueBooks();

            foreach (var book in allBooks)
            {
                Console.WriteLine(book.BookTitle);
            }
        }
        
    }
}