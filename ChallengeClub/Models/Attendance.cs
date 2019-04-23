using System;
using System.Collections.Generic;

namespace ChallengeClub.Models
{
    public class MemberAttendance
    {
        public string Name { get; set; }
        public int MemberLoginId { get; set; }
        public int MemberId { get; set; }
        public DateTime LoginDate { get; set; }

    
    }

    public class AttendanceModel
    {
        public IEnumerable<MemberAttendance> MemberAttendance { get; set; }
    }
}
