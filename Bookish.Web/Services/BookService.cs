using System.Collections.Generic;
using Bookish.DataAccess.Clients;
using Bookish.DataAccess.dbModels;

namespace Bookish.Web.Services
{
    public class BookService
    {
        private DbClient _dbClient;

        public BookService()
        {
            _dbClient = new DbClient();
        }

        public List<Book> GetAllBooks()
        {
            return _dbClient.GetAllBooks();
        }

    }
}