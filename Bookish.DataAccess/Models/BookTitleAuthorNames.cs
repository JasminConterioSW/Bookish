using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Bookish.DataAccess.dbModels;
using Dapper;
using Microsoft.VisualBasic;

namespace Bookish.DataAccess.Models
{
    public class BookTitleAuthorNames
    {
        
        public string BookTitle { get; set; }
        public IEnumerable<List<string>> AuthorNames { get; set; }
        public int NCopies { get; set; }
        public int NAvailableCopies { get; set; }

        public BookTitleAuthorNames (IDbConnection db, string isbn)
        {

            var parameters = new { Isbn = isbn};
            
            
            var sampleBookId = db.Query<int>(@"SELECT Id
                FROM Book
                WHERE ISBN = @Isbn", parameters).First(); // get the ID of one copy of the book with this ISBN*/ 

            var parameters2 = new {Isbn = isbn, BookID = sampleBookId}; 

            

            
            BookTitle = db.Query<string>(@"SELECT Title 
                            FROM Book 
                            WHERE ID = @BookId", parameters2).First();

            AuthorNames = db.Query<List<string>>(@"SELECT AuthorName
                                FROM Author
                                INNER JOIN AuthorBook AB on Author.Id = AB.AuthorId
                                WHERE AB.BookId = @BookId",parameters2);
            
            NCopies = db.Query<int>(@"SELECT COUNT(Id)
                                    FROM Book
                                    WHERE ISBN = @Isbn
                                    GROUP BY ISBN", parameters2).First();
            
            /*
            NCopies = db.Query<int>(@"SELECT COUNT(Id)
                                    FROM Book
                                    WHERE ISBN = '978-0756404079'
                                    GROUP BY ISBN
                                    ").First();
                                    */
            
            
            

        }
    }
}