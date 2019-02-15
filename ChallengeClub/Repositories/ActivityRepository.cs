using Dapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChallengeClub.Repositories
{
    public class Activity
    {
        public string ActivityId { get; set; }
    }

    public class ActivityRepository
    {
        public readonly IConfiguration configuration;

        public ActivityRepository(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        public List<Activity> GetActivity()
        {
            throw new System.NotImplementedException();
        }

        public Activity GetActivityById(string activityId)
        {
            var connectionString = configuration.GetConnectionString("ClubChallengeDB");
            using (var connection = SqlConnectionFactory.GetSqlConnection(connectionString))
            {
                const string query = @"
                    SELECT 
                        m.ActivityId
                    FROM Member m
                    WHERE m.Id = @ActivityId";

                var activity = connection.QuerySingleOrDefault<Activity>(query, new { ActivityId = activityId });

                return activity;
            }
        }
    }
}
