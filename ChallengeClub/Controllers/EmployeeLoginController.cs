using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ChallengeClub.Models;


namespace ChallengeClub.Controllers
{
    public class EmployeeLoginController : Controller
    {
       
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login()
        {
            return View("Views/Employee/EmployeeDashboardHome.cshtml");
        }
    }
}
