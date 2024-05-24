using System;
using System.ComponentModel.DataAnnotations;

namespace ProductMarketingApp.Models
{
    public class User
    {
        public int UserId { get; set; }

        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }

        public string Email { get; set; }

        public string FullName { get; set; }

        public string ProfileImage { get; set; }
    }
}
