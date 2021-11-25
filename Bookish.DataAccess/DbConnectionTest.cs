
using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Dapper;

namespace Bookish.DataAccess

    


{
    public class DbConnectionTest
    {
        public static void TestDbConnection()
        {
            using (IDbConnection db = new SqlConnection("Server=localhost;Trusted_Connection=true"))
            {
                db.Open();
                //var result = db.Query<string>("SELECT 'Hello World'").Single();
                var result = db.Query<string>("SELECT Title FROM Book").First();
                Console.WriteLine(result);
            }
        }
    }
}