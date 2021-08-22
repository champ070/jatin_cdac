using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Poc.Models
{
    public class Employee : IdentityUser
    {
        public int EmployeeId { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }        
        public string City { get; set; }
        public int CompanyID { get; set; }
        public Company Company { get; set; }
    }
}
