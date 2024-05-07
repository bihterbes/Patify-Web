using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Patify.Models
{
    public class AppUser : IdentityUser
    {
        [Required]
        public string FirstName { get; set; }
        
        [Required]
        public string LastName { get; set; }

        public string Phone { get; set; }
    }
}
