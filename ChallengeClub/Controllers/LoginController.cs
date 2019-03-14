using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ChallengeClub.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Configuration;
using Microsoft.Extensions.Configuration;

namespace ChallengeClub.Controllers
{
    [Route("Login")]
    public class LoginController : Controller
    {
        public readonly IConfiguration configuration;
        public readonly MemberRepository memberRepository;
        public LoginController(IConfiguration configuration)
        {
            this.configuration = configuration;
            memberRepository = new MemberRepository(configuration);
        }

        [HttpGet("{memberId}")]
        public IActionResult GetMemberById(string memberId)
        {
            var number = memberRepository.GetMemberById(memberId);
            return Ok(number);
        }

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
            if (member == null)
            {
                ViewBag.Error = "The number is Invalid.  Please Try Again.";
                return View();
            }

            return View("Views/Icon/Icon.cshtml");
        }
    }
}