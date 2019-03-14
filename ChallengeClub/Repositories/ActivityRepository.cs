using Dapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ChallengeClub.Models;

namespace ChallengeClub.Repositories
{
    public class Activity
    {
        public string ActivityId { get; set; }
        public string ActivityName { get; set; }
        public string StartTime { get; set; }
        public bool IsCheck { get; set; }
        public string ActivityImage { get; set; }
    }

    public class ActivityRepository
    {
        public readonly IConfiguration configuration;

        public ActivityRepository(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        public IEnumerable<Activity> GetActivities()
        {
            var connectionString = configuration.GetConnectionString("ClubChallengeDB");
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
            var connectionString = configuration.GetConnectionString("ClubChallengeDB");
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
    }
}
