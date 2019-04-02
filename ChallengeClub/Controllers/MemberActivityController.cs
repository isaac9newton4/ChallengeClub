using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ChallengeClub.Models;
using System.Text;
using Microsoft.Extensions.Configuration;
using ChallengeClub.Repositories;

namespace ChallengeClub.Controllers
{
    [Route("MemberActivity")]
    public class MemberActivityController : Controller
    {
        public readonly IConfiguration configuration;
        public readonly ActivityRepository activityRepository;
        public MemberActivityController(IConfiguration configuration)
        {
            this.configuration = configuration;
            activityRepository = new ActivityRepository(configuration);
        }

        [HttpGet]
        public IActionResult MemberActivity()
        {
            List<MemberActivity> DailyList = new List<MemberActivity>();

            DailyList.Add(new MemberActivity()
            {
                ActivityId = 1,
                ActivityName = "Bowling",
                StartTime = "10 am",
                ActivityImage = "/images/bowling.jpg",
                IsCheck = false
            });

            DailyList.Add(new MemberActivity()
            {
                ActivityId = 2,
                ActivityName = "Pet Therapy",
                StartTime = "1 pm",
                ActivityImage = "/images/pet.png",
                IsCheck = false
            });

            DailyList.Add(new MemberActivity()
            {
                ActivityId = 3,
                ActivityName = "Volunteer",
                StartTime = "3 pm",
                ActivityImage = "/images/volunteer.jpg",
                IsCheck = false
            });

            DailyList.Add(new MemberActivity()
            {
                ActivityId = 4,
                ActivityName = "Whitey's Dinner",
                StartTime = "6 pm",
                ActivityImage = "/images/dinner.jpg",
                IsCheck = false
            });

            DailyList.Add(new MemberActivity()
            {
                ActivityId = 5,
                ActivityName = "Dancing",
                StartTime = "8 pm",
                ActivityImage = "/images/dance.jpg",
                IsCheck = false
            });

            //IEnumerable<Activity> activity = activityRepository.GetActivities();

            ActivityList ShowList = new ActivityList();

            ShowList.DailyActs = DailyList;

            ShowList.SelectedActs = new List<MemberActivity> { }; 

            return View(ShowList);
        }

    

        [HttpPost]
        public IActionResult MemberActivity(ActivityList ls)
        {
            
            List<MemberActivity> TableList = new List<MemberActivity>();

             foreach (var item in ls.DailyActs) {
                 if (item.IsCheck) {
                    TableList.Add(item);
                 }
             }
             ActivityList ConfirmList = new ActivityList();
            
            ConfirmList.SelectedActs = TableList;
            ConfirmList.DailyActs = ls.DailyActs;

            return View(ConfirmList);
        }

        
    }
}