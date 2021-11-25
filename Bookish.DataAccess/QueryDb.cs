using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Bookish.DataAccess.dbModels;
using Dapper;

namespace Bookish.DataAccess
{
    
    
    
    public class QueryDb
    {

        private string SqlConnectionString = "Server=localhost;Trusted_Connection=true";
        
        public List<Book> GetAllBooks()
        {
            var allBooks = new List<Book>();
            
            using (IDbConnection db = new SqlConnection(SqlConnectionString))
            {
                db.Open();
                allBooks = db.Query<dbModels.Book>("SELECT * FROM Book") as List<Book>;

            }
            return allBooks;
        }
    }
}