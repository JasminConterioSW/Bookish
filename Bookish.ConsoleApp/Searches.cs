using System;
using Bookish.DataAccess.Clients;

namespace Bookish.ConsoleApp
{
    public class Searches
    {
        public void PrintAllBooks()
        {
            var dbClient = new DbClient();
            var allBooks = dbClient.GetAllBooks();

            foreach (var book in allBooks)
            {
                Console.WriteLine(book.Title);
            }
            
        }

        public void PrintAllUniqueBooks()
        {
            var dbClient = new DbClient();
            var allBooks = dbClient.GetAllUniqueBooks();

            foreach (var book in allBooks)
            {
                Console.WriteLine($"{book.BookTitle} : Available copies {book.NAvailableCopies}");
                /*foreach (var author in book.AuthorNames)
                {
                    Console.WriteLine(author);
                }*/
            }
        }
        
    }
}