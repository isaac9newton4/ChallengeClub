using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ChallengeClub.Models;

namespace ChallengeClub.Controllers
{
    public class ActivityItem
    {
        private MemberActivity activity = new MemberActivity();

        public MemberActivity Activity
        { get => activity;
          set => activity = value;
        }

        public ActivityItem()
        { }

        public ActivityItem(MemberActivity activity)
        {
            this.activity = activity;
        }

        
    }
}
