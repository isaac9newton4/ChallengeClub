using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ChallengeClub.Models;
using Microsoft.Extensions.Configuration;
using ChallengeClub.Repositories;



namespace ChallengeClub.Controllers
{
    [Route("Attendance")]
    public class AttendanceController : Controller
    {

        public readonly IConfiguration configuration;
        public readonly MemberLoginRepository memberLoginRepository;
        public readonly MemberRepository memberRepository;


        public AttendanceController(IConfiguration configuration)
        {
            this.configuration = configuration;
            memberLoginRepository = new MemberLoginRepository(configuration);
        }




        [HttpGet]
        public IActionResult Attendance()
        {
            //var model = new MemberAttendance { MemberLoginId =  };


            var result = this.memberLoginRepository.GetAttendanceByDate();

            var model = new AttendanceModel
            {
                MemberAttendance = result
            };
            return View("Attendance", model);


        }

    }

}