using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ChallengeClub.Controllers
{
    [Route("Login")]
    public class LoginController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult Index([FromForm]string memberId)
        {
            
            int num = 0;
            bool isNumber = int.TryParse(memberId, out num);
            if (string.IsNullOrWhiteSpace(memberId) || memberId.Length != 4 || isNumber == false)
            {
                ViewBag.Error = "The number is Invalid.  Please Try Again.";
                return View();

            }

            return View("Views/Icon/Icon.cshtml");

        }
    }
}