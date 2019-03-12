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
        private readonly MemberActivityRepository memberActivityRepository;


        public MemberActivityConfirmController(IConfiguration configuration)
        {
            this.configuration = configuration;
            activityRepository = new ActivityRepository(configuration);
            memberRepository = new MemberRepository(configuration);
            memberActivityRepository = new MemberActivityRepository(configuration);
        }
        public ActionResult MemberActivityConfirm()
        {
            ViewBag.Message = "Your application description page.";
            ViewBag.Members = this.memberRepository.GetMembers();
            ViewBag.Activities = this.activityRepository.GetActivities();
            ViewBag.MemberActivities = this.memberActivityRepository.GetMemberActivities();
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