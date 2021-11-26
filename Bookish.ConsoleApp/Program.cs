using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Dapper;
using Bookish.DataAccess;

namespace Bookish.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //DataAccess.Clients.DbConnectionTest.TestDbConnection();
            
            var searcher = new Searches();
            //searcher.PrintAllBooks();
            searcher.PrintAllUniqueBooks();

        }
    }
}


