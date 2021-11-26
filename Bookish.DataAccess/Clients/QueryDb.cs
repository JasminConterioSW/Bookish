using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Bookish.DataAccess.dbModels;
using Bookish.DataAccess.Models;
using Dapper;

namespace Bookish.DataAccess.Clients
{
    
    
    
    public class QueryDb
    {

        private string SqlConnectionString = "Server=localhost;Trusted_Connection=true";
        
        public List<Book> GetAllBooks()
        {
            // this gets all entries in the "book" table. There may be multiple entries for each book if there are multiple copies
            
            var allBooks = new List<Book>();
            
            using (IDbConnection db = new SqlConnection(SqlConnectionString))
            {
                db.Open();
                allBooks = db.Query<dbModels.Book>(@"SELECT * 
                FROM Book") as List<Book>;

            }
            return allBooks;
        }

        public List<BookTitleAuthorNames> GetAllUniqueBooks()
        {
            // Aim here is to list library books (one entry for each book isbn).
            // Eventually List title, author(s), number of copies library has, number of books available.
            List<BookTitleAuthorNames> libraryBooks = new List<BookTitleAuthorNames>();
            
            List<ISBN> isbns = GetISBNs();

            using (IDbConnection db = new SqlConnection(SqlConnectionString))
            {
                db.Open();
                foreach (var i in isbns)
                {
                    libraryBooks.Add(new BookTitleAuthorNames(db, i.Isbn));
                }
            }
            



            return libraryBooks;
        }

        private List<ISBN> GetISBNs()
        {
            List<ISBN> isbns;
            
            using (IDbConnection db = new SqlConnection(SqlConnectionString))
            {
                db.Open();
                isbns = (List<ISBN>) db.Query<dbModels.ISBN>(@"SELECT ISBN 
                FROM Book GROUP BY ISBN");
            }

            return isbns;
        }
        
    }
}