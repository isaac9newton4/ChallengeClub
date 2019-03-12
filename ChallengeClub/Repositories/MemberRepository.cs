using Dapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ChallengeClub.Models;

namespace ChallengeClub.Repositories
{
    public class MemberRepository
    {
        public readonly IConfiguration configuration;
        public MemberRepository(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        public IEnumerable<Member> GetMembers()
        {
            var connectionString = configuration.GetConnectionString("ClubChallengeDB");
            using (var connection = SqlConnectionFactory.GetSqlConnection(connectionString))
            {
                const string query = @"
                    SELECT m.*
                    FROM Member m
                ";

                return connection.Query<Member>(query);
            }
        }

        public Member GetMemberById(string number)
        {
            var connectionString = configuration.GetConnectionString("ClubChallengeDB");
            using (var connection = SqlConnectionFactory.GetSqlConnection(connectionString))
            {
                const string query = @"
                    SELECT m.*
                    FROM Member m
                    WHERE m.MemberNumber = @Number
                ";

                return connection.QuerySingleOrDefault<Member>(query, new { Number = number });
            }
        }
    }
}
