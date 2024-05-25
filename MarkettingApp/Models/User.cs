using System.ComponentModel.DataAnnotations;

namespace ProductMarketingApp.Models
{
    public class User
    {
        public User()
        {
            Username = string.Empty;
            Password = string.Empty;
            Email = string.Empty;
            FullName = string.Empty;
            ProfileImage = string.Empty;
        }

        public int UserId { get; set; }

        [Required]
        [MaxLength(100)]
        public string Username { get; set; }

        [Required]
        [MaxLength(100)]
        public string Password { get; set; }

        [MaxLength(100)]
        public string Email { get; set; }

        [MaxLength(100)]
        public string FullName { get; set; }

        [MaxLength(255)]
        public string ProfileImage { get; set; }
    }
}
