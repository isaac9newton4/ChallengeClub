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
        public IActionResult Login(EmployeeLoginView elv)
        {
            EmployeeData ed = new EmployeeData();
            if (string.IsNullOrEmpty(elv.EmployeeAccount.Username) || string.IsNullOrEmpty(elv.EmployeeAccount.Password) ||
                ed.Login(elv.EmployeeAccount.Username, elv.EmployeeAccount.Password) == null)
            {
                ViewBag.Error = "Account is Invalid. Please try again.";
                return View("Views/EmployeeLogin/Index");
            }
            return View("Views/Employee/EmployeeDashboardHome.cshtml");
        }
    }
}
