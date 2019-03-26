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

        public List<Activity> GetActivity()
        {
            throw new System.NotImplementedException();
        }

        public Activity GetActivityById(int activityId)
        {
            var connectionString = configuration.GetConnectionString("ClubChallengeDB");
            using (var connection = SqlConnectionFactory.GetSqlConnection(connectionString))
            {
                const string query = @"
                    SELECT 
                          ActivityId
                    FROM dbo.Activity
                    WHERE ActivityId = @activityId";

                var activity = connection.QuerySingleOrDefault<Activity>(query, new { ActivityId = activityId });

                return activity;
            }
        }
    }
}
