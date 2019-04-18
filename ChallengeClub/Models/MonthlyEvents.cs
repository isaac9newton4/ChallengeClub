using System;
using System.Collections.Generic;

namespace ChallengeClub.Models
{
    public class MonthlyEvents
    {
        public int EventId { get; set; }
        public string Title { get; set; }
        public string Date { get; set; }
        public string Description { get; set; }

    }

    public class EventsModel
    {
        public IEnumerable<MonthlyEvents> MonthlyEvents { get; set; }
    }
}
