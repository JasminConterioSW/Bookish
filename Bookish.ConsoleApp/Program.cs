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
            Bookish.DataAccess.DbConnectionTest.TestDbConnection();
            //Bookish.DataAccess.DbConnectionTest.TestDbConnection();
        }
    }
}


