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
    [Route("EmployeeLogin")]
    public class EmployeeLoginController : Controller
    {

        public readonly IConfiguration configuration;
        public readonly EmployeeRepository employeeRepository;
        public EmployeeLoginController(IConfiguration configuration)
        {
            this.configuration = configuration;
            employeeRepository = new EmployeeRepository(configuration);
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index([FromForm]string username, string password)
        {
        
            if (string.IsNullOrWhiteSpace(username))
            {
                ViewBag.Error = "The Username cannot contain space.  Please Try Again.";
                return View();

            }

            var empolyee = employeeRepository.GetEmployeeByUsername(username);
            if (empolyee == null)
            {
                ViewBag.Error = "The user is not exist.  Please Try Again.";
                return View();
            }


           else
            {
                if (password == empolyee.Password)
                {
                    return View("Views/EmployeeDashboardHome/EmployeeDashboardHome.cshtml");
                }
                else ViewBag.Error = "The Password is wrong. Please Try Again.";
                return View();
            }
        }
    }
}
