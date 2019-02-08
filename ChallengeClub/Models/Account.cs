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
        [StringLength(4,MinimumLength=4, ErrorMessage = "Member ID must be 4 digit.")]
        public string MemberId { get; set; }
        public string message { get; set; }    
    }
}
