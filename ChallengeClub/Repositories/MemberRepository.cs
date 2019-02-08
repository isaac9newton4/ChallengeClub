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
        public string MemberId { get; set; }
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

        public Member GetMemberById(string memberId)
        {
            var connectionString = configuration.GetConnectionString("ClubChallengeDB");
            using (var connection = SqlConnectionFactory.GetSqlConnection(connectionString))
            {
                const string query = @"
                    SELECT 
                        m.MemberId
                    FROM Member m
                    WHERE m.Id = @MemberId";

                var member = connection.QuerySingleOrDefault<Member>(query, new { MemberId = memberId });

                return member;
            }
        }
    }
}
