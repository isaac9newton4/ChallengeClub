using ChallengeClub.Models;
using Dapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChallengeClub.Repositories
{
    public class EmployeeRepository
    {
        public readonly IConfiguration configuration;
        public EmployeeRepository(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        public IEnumerable<Employee> GetEmployee()
        {
            var connectionString = configuration.GetConnectionString("ClubChallengeDB");
            using (var connection = SqlConnectionFactory.GetSqlConnection(connectionString))
            {
                const string query = @"
                    SELECT e.*
                    FROM Employee e
                ";

                return connection.Query<Employee>(query);
            }
        }

        public Employee GetEmployeeByUsername(string userName)
        {
            var connectionString = configuration.GetConnectionString("ClubChallengeDB");
            using (var connection = SqlConnectionFactory.GetSqlConnection(connectionString))
            {
                const string query = @"
                    SELECT e.*
                    FROM Employee e
                    WHERE e.UserName = @Username
                ";

                return connection.QuerySingleOrDefault<Employee>(query, new { Username = userName });
            }
        }

    }
}
