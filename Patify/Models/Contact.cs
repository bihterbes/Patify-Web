using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Patify.Models
{
    public class Contact
    {
        public int Id { get; set; }

        public string NameSurname { get; set; }
        
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        public string Phone { get; set; }

        public string Subject { get; set; }

        [Required]
        public string Message { get; set; }
    }
}
