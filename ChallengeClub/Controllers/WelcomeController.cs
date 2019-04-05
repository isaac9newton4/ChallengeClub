using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Configuration;
using Microsoft.Extensions.Configuration;
using ChallengeClub.Repositories;

namespace ChallengeClub.Controllers
{
    public class WelcomeController : Controller
    {
        [Route("Welcome")]
       
        public IActionResult Welcome()
        {

            return View();
        }
    }
}