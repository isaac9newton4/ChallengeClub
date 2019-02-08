using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChallengeClub.Models
{
    public class Welcome
    {
        public int MemberId { get; set; }
        public string MemberName { get; set; }
    }

    public class NameList {

        public List<Welcome> MemberList { get; set; }
        
    }
}
