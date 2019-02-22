using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ChallengeClub.Models
{
    public class Account
    {
        [Required]
        public string MemberId { get; set; }
        public string message { get; set; }    
    }
}
