using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace FormLogin
{
    internal class DbHelper
    {
        private static string connStr = "Server=localhost;Database=PuzzleExamDB;Integrated Security=True;";
        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connStr);
        }

    }
}