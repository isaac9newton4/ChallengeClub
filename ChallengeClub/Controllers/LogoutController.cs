using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ChallengeClub.Controllers
{
    public class LogoutController : Controller
    {
        [Route("Logout")]
        public IActionResult Logout()
        {

            return View();
        }
    }
}