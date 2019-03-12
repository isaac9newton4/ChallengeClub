using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ChallengeClub.Repositories;
using Microsoft.AspNetCore.Mvc;
<<<<<<< HEAD
using ChallengeClub.Repositories;
using System.Configuration;
=======
>>>>>>> 3b54639247ddc161625153995426b83f33240982
using Microsoft.Extensions.Configuration;

namespace ChallengeClub.Controllers
{
    [Route("Login")]
    public class LoginController : Controller
    {
<<<<<<< HEAD
        public readonly IConfiguration configuration;
        public readonly MemberRepository memberRepository;
=======
        private readonly IConfiguration configuration;
        private readonly MemberRepository memberRepository;

>>>>>>> 3b54639247ddc161625153995426b83f33240982
        public LoginController(IConfiguration configuration)
        {
            this.configuration = configuration;
            memberRepository = new MemberRepository(configuration);
<<<<<<< HEAD
        }

        [HttpGet("{memberId}")]
        public IActionResult GetMemberById(string memberId)
        {
            var number = memberRepository.GetMemberById(memberId);
            return Ok(number); 
        }

=======
            
        }
>>>>>>> 3b54639247ddc161625153995426b83f33240982
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult Index([FromForm]string memberId)
        {
            var isNumber = int.TryParse(memberId, out _);
            if (string.IsNullOrWhiteSpace(memberId) || memberId.Length != 4 || !isNumber)
            {
                ViewBag.Error = "The number is Invalid.  Please Try Again.";
                return View();

            }

            var member = memberRepository.GetMemberById(memberId);
<<<<<<< HEAD
            if (member == null)
            {
                ViewBag.Error = "The number is Invalid.  Please Try Again.";
                return View();
            }
         
=======

>>>>>>> 3b54639247ddc161625153995426b83f33240982
            return View("Views/Icon/Icon.cshtml");
        }
    }
}