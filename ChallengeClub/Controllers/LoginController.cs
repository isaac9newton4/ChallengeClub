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
        public IActionResult Login()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult Login([FromForm]string memberId)
        {
            // Validation
            /*string message = "";
            if (string.IsNullOrWhiteSpace(memberId))
            {
                message = "Member ID can not be null or contain any white space.";
            }

            if (memberId.Length != 4)
            {
                message = "Member ID must be 4 digits";
            }

            int num = 0;
            bool isNumber = int.TryParse(memberId, out num);
            if (isNumber == false)
            {
                message = "Member ID must be 4 digits number";
            }

            return message;*/
            int num = 0;
            bool isNumber = int.TryParse(memberId, out num);
            if (string.IsNullOrWhiteSpace(memberId) || memberId.Length != 4 || isNumber == false)
            {
                ViewBag.Error = "The number is Invalid.  Please Try Again.";
                return View("Views/Login/Login.cshtml");

            }

            return View("Views/Icon/Icon.cshtml");

        }
    }
}