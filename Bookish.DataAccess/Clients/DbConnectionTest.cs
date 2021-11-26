using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Dapper;

namespace Bookish.DataAccess.Clients

    


{
    public class DbConnectionTest
    {
        public static void TestDbConnection()
        {
            using (IDbConnection db = new SqlConnection("Server=localhost;Trusted_Connection=true"))
            {
                db.Open();
                //var result = db.Query<string>("SELECT Title FROM Book").First();
                //var result = db.Query<dbModels.Book>("SELECT * FROM Book").First();
                //var result = db.Query<dbModels.Book>("SELECT * FROM Book");
                var result = db.Query(@"SELECT Title FROM Book WHERE Id = 1").First();
                
                Console.WriteLine(result);
            }
        }
    }
}