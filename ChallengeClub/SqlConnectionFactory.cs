using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace ChallengeClub
{
    public static class SqlConnectionFactory
    {
        public static SqlConnection GetSqlConnection(string connectionString) {
            return new SqlConnection(connectionString);
        }
    }
}
