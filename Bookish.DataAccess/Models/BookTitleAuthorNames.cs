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
        public List<string> AuthorNames { get; set; }
        public int NCopies { get; set; }
        public int NAvailableCopies { get; set; }

        public BookTitleAuthorNames (IDbConnection db, string isbn)
        {

            var parameters = new {Isbn = isbn};
            
            int sampleBookId = db.Query(@"SELECT Id
                FROM Book
                WHERE ISBN = ${Isbn}", parameters).First().ToInt(); // get the ID of one copy of the book with this ISBN


            var parameters2 = new {Isbn = isbn, BookID = sampleBookId}; 
            //var parameters = new {BookID = sampleBookId};
            

            
            BookTitle = db.Query(@"SELECT Title 
                            FROM Book 
                            WHERE ID = ${BookId}", parameters2).ToString();
            
            
            //AuthorNames 
            AuthorNames = (List<string>) db.Query(@"SELECT AuthorName
                                FROM Author
                                INNER JOIN AuthorBook AB on Author.Id = AB.AuthorId
                                WHERE AB.BookId = ${BookId}",parameters2);


            NCopies = db.Query(@"SELECT COUNT(Id)
                                    FROM Book
                                    WHERE ISBN = isbn
                                    GROUP BY ISBN
                                    ").First().ToInt();
        }
    }
}