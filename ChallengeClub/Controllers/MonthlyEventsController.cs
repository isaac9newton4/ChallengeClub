using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ChallengeClub.Models;
using Microsoft.Extensions.Configuration;
using ChallengeClub.Repositories;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ChallengeClub.Controllers
{
    [Route("MonthlyEvents")]
    public class MonthlyEventsController : Controller
    {

        public readonly IConfiguration configuration;
        public readonly MonthlyEventsRepository monthlyEventsRepository;
        public MonthlyEventsController(IConfiguration configuration)
        {
            this.configuration = configuration;
            monthlyEventsRepository = new MonthlyEventsRepository(configuration);
        }


        [HttpGet]
        public IActionResult MonthlyEvents()
        {
            ViewBag.Events = this.monthlyEventsRepository.GetMonthlyEvents();
            return View();
        }

        [HttpPost]
        public IActionResult MonthlyEvents([FromForm]string eventTitle, DateTime eventDate, string eventDescription)
        {

            monthlyEventsRepository.AddMonthlyEvent(eventTitle, eventDate, eventDescription);

            ViewBag.Error = "The user is not exist.  Please Try Again.";
            return View();

        }
    }
}
