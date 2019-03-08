using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ChallengeClub.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace ChallengeClub.Controllers
{
    [Route("Login")]
    public class LoginController : Controller
    {
        private readonly IConfiguration configuration;
        private readonly MemberRepository memberRepository;

        public LoginController(IConfiguration configuration)
        {
            this.configuration = configuration;
            memberRepository = new MemberRepository(configuration);
        }

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

            var member = memberRepository.GetMemberById(memberId);

            return View("Views/Icon/Icon.cshtml");

        }
    }
}