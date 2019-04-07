using Dapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ChallengeClub.Models;

namespace ChallengeClub.Repositories
{
    public class ActivityDefinitionRepositories
    {
        public readonly IConfiguration configuration;

        public ActivityDefinitionRepositories(IConfiguration configuration)
        {
            this.configuration = configuration;
        }
    }
}
