using Dapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace ChallengeClub.Repositories
{
    public class Member
    {
        public string MemberNumber { get; set; }
        public string Name { get; set; }
        public string IconPath { get; set; }
    }

    public class MemberRepository
    {
        public readonly IConfiguration configuration;
        public MemberRepository(IConfiguration configuration)
        {
            this.configuration = configuration;
        }
        public List<Member> GetMembers()
        {
            throw new System.NotImplementedException();
        }

        public Member GetMemberById(string memberNumber)
        {
            var connectionString = configuration.GetConnectionString("ChallengeClubDB");
            using (var connection = SqlConnectionFactory.GetSqlConnection(connectionString))
            {
                const string query = @"
                    SELECT 
                        MemberNumber,
                        Name,
                        IconPath
                    FROM dbo.Member
                    WHERE MemberNumber = @memberNumber";

                var member = connection.QuerySingleOrDefault<Member>(query, new { MemberNumber = memberNumber });

                return member;
            }
        }
    }
}
