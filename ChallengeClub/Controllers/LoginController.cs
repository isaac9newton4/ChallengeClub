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
        public IActionResult LoginPost([FromForm]string memberId)
        {
            // Validation
            if (string.IsNullOrWhiteSpace(memberId))
            {
                return BadRequest("memberId must not be null or empty");
            }



            return View();
        }
    }
}