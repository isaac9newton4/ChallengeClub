using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ChallengeClub.Models;
using ChallengeClub.Repositories;
using Microsoft.Extensions.Configuration;

namespace ChallengeClub.Controllers
{
    public class MemberActivityConfirmController : Controller
    {
        private readonly IConfiguration configuration;
        private readonly ActivityRepository activityRepository;
        private readonly MemberRepository memberRepository;

        public MemberActivityConfirmController(IConfiguration configuration)
        {
            this.configuration = configuration;
            activityRepository = new ActivityRepository(configuration);
            memberRepository = new MemberRepository(configuration);
        }
        
      //ViewBag.MemberActivities = new AppContext().MemberActivities.ToArray();

        public ActionResult MemberActivityConfirm()
        {
            return View();
        }

        public ActionResult Confirm()
        {
            ViewBag.Message = "Your application description page.";
            ViewBag.Members = new List<string>()
            {
                //memberRepository
                "John Smith", "Andy Wilhouse","Mary Stewart","Catherine McDonald", "Anduin Wrynn", "Jaina Proudmoore", "Sylvanas Windrunner"
            };
            ViewBag.Activities = new List<string>()
            {
                
                "Recreational Activity","Employment Training", "Computer Lab",
                "Advocacy Training", "Volunteer", "Arts & Crafts", "Gardening", "Reading/Library",
                "Exercise", "Social Games", "Family & Friends (After Hours)", "Other"
            };
            
            return View();
        }

 

        // POST: Order/Create
        //[HttpPost]
        //public ActionResult Create(FormCollection collection)
        //{
        //    // TODO: Add insert logic here
        //    AppContext context = new AppContext();
        //    MemberActivity model = context.MemberActivities.Add(new MemberActivity()
        //    {
        //        Member = collection.Get("Member"),
        //        Activity = collection.Get("Activity")
        //    });
        //    context.SaveChanges();
        //    return RedirectToAction("About");
        //}

        // POST: Order/Delete/5
        //    [HttpPost]
        //    public ActionResult Delete(int id, FormCollection collection)
        //    {
        //        // TODO: Add delete logic here
        //        AppContext context = new AppContext();
        //        MemberActivity model = context.MemberActivities.Find(id);
        //        context.MemberActivities.Remove(model);
        //        context.SaveChanges();
        //        return RedirectToAction("Confirm");
        //    }
        //}
    }
}