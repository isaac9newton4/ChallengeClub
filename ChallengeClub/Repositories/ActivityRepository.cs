using Dapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ChallengeClub.Models;

namespace ChallengeClub.Repositories
{
    public class ActivityRepository
    {
        public readonly IConfiguration configuration;

        public ActivityRepository(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        public IEnumerable<Activity> GetActivities()
        {
            var connectionString = configuration.GetConnectionString("ChallengeClubDB");
            using (var connection = SqlConnectionFactory.GetSqlConnection(connectionString))
            {
                const string query = @"
                    SELECT a.*
                    FROM Activity a
                ";

                return connection.Query<Activity>(query);
            }
        }

        public Activity GetActivityById(string id)
        {
            var connectionString = configuration.GetConnectionString("ChallengeClubDB");
            using (var connection = SqlConnectionFactory.GetSqlConnection(connectionString))
            {
                const string query = @"
                    SELECT a.*
                    FROM Activity a
                    WHERE a.ActivityId = @Id
                ";

                return connection.QuerySingleOrDefault<Activity>(query, new { Id = id });
            }
        }

        public void AddActivity(string name, int hours, string description, DateTime date)
        {
            var connectionString = configuration.GetConnectionString("ChallengeClubDB");
            using (var connection = SqlConnectionFactory.GetSqlConnection(connectionString))
            {
                const string query = @"
                    INSERT INTO Activity(Name,Hours,Description,Date)
                    VALUES(@Name,@Hours,@Description,@Date)
                ";

                connection.Execute(query, new { Name = name, Hours = hours, Description = description, Date = date });
            }
        }




    }
}
