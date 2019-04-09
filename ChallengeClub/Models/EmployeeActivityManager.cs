using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChallengeClub.Models
{
    public class EmployeeActivityManager
    {
        public int ActivityId { get; set; }
        public string Name { get; set; }
        public int Hours { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
    }

    public class EmployeeActivityDefinition
    {

        public string Name { get; set; }
        public int Hours { get; set; }
        public string Description { get; set; }

    }
}
