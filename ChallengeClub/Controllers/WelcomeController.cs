using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ChallengeClub.Models;

namespace ChallengeClub.Controllers
{
    public class WelcomeController : Controller
    {
        [Route("Welcome")]
        [HttpGet]
        public IActionResult Welcome()
        {
            List<Welcome> LoginMember = new List<Welcome>();

            LoginMember.Add(new Welcome()
            {
                MemberId = 1111,
                MemberName = "John"
               
            });
            LoginMember.Add(new Welcome()
            {
                MemberId = 2222,
                MemberName = "Elise"

            }); LoginMember.Add(new Welcome()
            {
                MemberId = 3333,
                MemberName = "William"

            });
            return View();
        }
    }
}