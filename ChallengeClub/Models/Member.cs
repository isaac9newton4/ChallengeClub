using System;
using System.Collections.Generic;

namespace ChallengeClub.Models
{
    public class Member
    {
        public string Name { get; set; }
        public int MemberLoginId { get; set; }
        public int MemberId { get; set; }
        public DateTime LoginDate { get; set; }
        public string IconPath { get; set; }
        public string MemberNumber { get; set; }
    }

    public class MemberModel
    {
        public IEnumerable<Member> Member { get; set; }
    }
}
