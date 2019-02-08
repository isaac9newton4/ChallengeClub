using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ChallengeClub.Controllers
{
    public class IconController : Controller
    {
        [Route("Icon")]
        public IActionResult Icon()
        {
            return View();
        }
    }
}