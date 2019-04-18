using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ChallengeClub.Models;
using Microsoft.Extensions.Configuration;
using ChallengeClub.Repositories;

namespace ChallengeClub.Controllers
{
    [Route("EmployeeActivityManager")]
    public class EmployeeActivityManagerController : Controller
    {

        public readonly IConfiguration configuration;
        public readonly ActivityRepository activityRepository;
        public readonly ActivityDefinitionRepositories activityDefinitionRepository;

        public EmployeeActivityManagerController(IConfiguration configuration)
        {
            this.configuration = configuration;
            activityRepository = new ActivityRepository(configuration);
            activityDefinitionRepository = new ActivityDefinitionRepositories(configuration);
        }

        [HttpGet]
        public IActionResult EmployeeActivityManager()
        {
            ViewBag.Activities = this.activityDefinitionRepository.GetActivityDefinition();
            return View();


        }

        [HttpPost]
        public IActionResult EmployeeActivityManager([FromForm]string activityName, int activityHours, string activityDescription)
        {

            activityDefinitionRepository.AddActivityDefinition(activityName, activityHours, activityDescription);

            ViewBag.Error = "The user is not exist.  Please Try Again.";
            return View();

        }


        public IActionResult GetName([FromForm]string queryName)
        {

            ViewBag.Submitted = this.activityDefinitionRepository.GetActivityDefinitionByName(queryName);

            var date = new DateTime();
            activityRepository.AddActivity(ViewBag.Submitted.Name, ViewBag.Submitted.Hours, ViewBag.Submitted.Description, date);

            return View();
        }


    }

<<<<<<< HEAD
}
=======
}
>>>>>>> jing/test
