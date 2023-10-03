using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace salon
{
    internal static class Database
    {
        private static readonly string connectionString = "Data Source=46.42.17.183;Initial Catalog=салон;Integrated Security=True";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
        public class Service
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public int Cost { get; set; }
        }

    }
}
