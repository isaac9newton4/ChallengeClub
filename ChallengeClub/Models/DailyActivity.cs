using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChallengeClub.Models
{
    public class DailyActivity
    {
        public int activityId { get; set; }
        public string activityName { get; set; }
        public string startTime { get; set; }
        public bool isCheck { get; set; }
    }

    public class actList
    {
        public List<DailyActivity> dailyActs { get; set; }

    }
}
