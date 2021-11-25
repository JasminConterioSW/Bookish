using System;

namespace Bookish.ConsoleApp
{
    public class Searches
    {
        public void PrintAllBooks()
        {
            var dbClient = new Bookish.DataAccess.QueryDb();
            var allBooks = dbClient.GetAllBooks();

            foreach (var book in allBooks)
            {
                Console.WriteLine(book.Title);
            }
            
        }
    }
}