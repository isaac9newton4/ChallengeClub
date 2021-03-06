﻿using Dapper;
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
            var connectionString = configuration.GetConnectionString("ChallengeClubDB");
            using (var connection = SqlConnectionFactory.GetSqlConnection(connectionString))
            {
                const string query = @"
                    SELECT m.*
                    FROM Member m
                ";

                return connection.Query<Member>(query);
            }
        }

        public Member GetMemberByNumber(string number)
        {
            var connectionString = configuration.GetConnectionString("ChallengeClubDB");
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

        public Member GetMemberById(int memberId)
        {
            
            var connectionString = configuration.GetConnectionString("ChallengeClubDB");
            using (var connection = SqlConnectionFactory.GetSqlConnection(connectionString))
            {
                const string query = @"
                    SELECT m.*
                    FROM Member m
                    WHERE m.MemberId = @MemberId
                ";

                return connection.QuerySingleOrDefault<Member>(query, new { MemberId = memberId });
            }
        }

        public void CreateMemberLogin(int memberId)
        {

            DateTime today = DateTime.Today;
            var connectionString = configuration.GetConnectionString("ChallengeClubDB");

            using (var connection = SqlConnectionFactory.GetSqlConnection(connectionString))
            {
                const string query = @"
                    INSERT INTO MemberLogin (MemberId, LoginDate)
                    VALUES (@MemberId, @LoginDate)
                ";

                connection.Execute(query, new { MemberId = memberId, LoginDate = today });
            }
        }

        public void AddNewMember(string name, int memberNumber)
        {
            var connectionString = configuration.GetConnectionString("ChallengeClubDB");
            using (var connection = SqlConnectionFactory.GetSqlConnection(connectionString))
            {
                var iconPath = "xxxx";
                const string query = @"
                    INSERT INTO Member(Name,IconPath,MemberNumber)
                    VALUES(@Name,@IconPath,@MemberNumber)
                ";

                connection.Execute(query, new { Name = name, IconPath = iconPath, MemberNumber = memberNumber });
            }
        }
    }
}
