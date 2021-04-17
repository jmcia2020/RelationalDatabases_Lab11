using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AsyncInn.Models.API
{
    public class RegisterData
    {
        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public string Email { get; set; }

        
        public string PhoneNumber { get; set; }

        // Allow specifying roles when registering
        public List<string> Roles { get; set; }


        //TO: what else? grad date?

    }
}
