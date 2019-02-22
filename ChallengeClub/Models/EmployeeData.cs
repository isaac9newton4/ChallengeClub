using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChallengeClub.Models
{
    public class EmployeeData
    {
        private List<EmployeeAccount> AccountList = new List<EmployeeAccount>();

        public EmployeeData()
        {
            AccountList.Add(new EmployeeAccount { Username = "Nancy", Password = "1234", Roles = new string[] { "admin", "employee" } });
            AccountList.Add(new EmployeeAccount { Username = "Melva", Password = "1234", Roles = new string[] { "employee" } });
        }

        public EmployeeAccount Find(string username)
        {
            return AccountList.Where(acc => acc.Username.Equals(username)).FirstOrDefault();
        }

        public EmployeeAccount Login(string username, string password)
        {
            return AccountList.Where(acc => acc.Username.Equals(username) && acc.Password.Equals(password)).FirstOrDefault();
        }
    }
}
