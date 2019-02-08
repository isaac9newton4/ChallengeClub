using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ChallengeClub.Models;
using System.Text;

namespace ChallengeClub.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult MemberLogin()
        {
            return View();
        }

        public IActionResult Icon()
        {

            return View();
        }

        public IActionResult Welcome()
        {

            return View();
        }

        [HttpGet]
        public IActionResult MemberActivity()
        {
            List<DailyActivity> dact = new List<DailyActivity>();

            dact.Add(new DailyActivity()
            {
                activityId = 1,
                activityName = "Bowling",
                startTime = "10 am",
                isCheck = false
            });

            dact.Add(new DailyActivity()
            {
                activityId = 2,
                activityName = "Pet Therapy",
                startTime = "1 pm",
                isCheck = false
            });

            dact.Add(new DailyActivity()
            {
                activityId = 3,
                activityName = "Volunteer",
                startTime = "3 pm",
                isCheck = false
            });

            dact.Add(new DailyActivity()
            {
                activityId = 4,
                activityName = "Whitey's Dinner",
                startTime = "6 pm",
                isCheck = false
            });

            dact.Add(new DailyActivity()
            {
                activityId = 5,
                activityName = "Dancing",
                startTime = "8 pm",
                isCheck = false
            });

            actList alist = new actList();

            alist.dailyActs = dact;

            return View(alist);

            /*DailyActivity bowling = new DailyActivity
            {
                activityName = "Bowling",
                startTime = "10 am",
            };

            DailyActivity pet = new DailyActivity
            {
                activityName = "Pet Therapy",
                startTime = "1 pm",
            };

            DailyActivity volunteer = new DailyActivity
            {
                activityName = "Volunteer",
                startTime = "1 pm",
            };

            DailyActivity wDinner = new DailyActivity
            {
                activityName = "Whitey's Dinner",
                startTime = "6 pm",
            };

            DailyActivity dancing = new DailyActivity
            {
                activityName = "Dancing",
                startTime = "8 pm",
            };*/

        }
        [HttpPost]
        public IActionResult MemberActivity(actList ac)
        {
            StringBuilder sb = new StringBuilder();
            foreach(var thing in ac.dailyActs)
            {
                if (thing.isCheck) {
                    sb.Append(thing.activityName + " at " + thing.startTime + ",  ");
                }
            }
            ViewBag.selectAct = "Your Activities are " + sb.ToString();
            return View(ac);
        }

        public IActionResult Confirm()
        {

            return View();
        }

        public IActionResult Logout()
        {

            return View();
        }
        [HttpGet]
        public IActionResult MemberActivityConfirm()
        {
            ViewBag.Message = "Member Activity Confirmation";
            ViewBag.Members = new List<string>()
            {
                "John Smith", "Andy Wilhouse","Mary Stewart","Catherine McDonald", "Anduin Wrynn", "Jaina Proudmoore", "Sylvanas Windrunner"
            };
            ViewBag.Activities = new List<string>()
            {
                "Recreational Activity","Employment Training", "Computer Lab",
                "Advocacy Training", "Volunteer", "Arts & Crafts", "Gardening", "Reading/Library",
                "Exercise", "Social Games", "Family & Friends (After Hours)", "Other"
            };
           //ViewBag.MemberActivitiyConfirm = new AppContext().MemberActivityConfirm.ToArray();

            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
