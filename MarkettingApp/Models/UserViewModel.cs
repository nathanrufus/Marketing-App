using System.ComponentModel.DataAnnotations;

namespace ProductMarketingApp.Models
{
    public class RegisterViewModel
    {
        public RegisterViewModel()
        {
            Username = string.Empty;
            Password = string.Empty;
            Email = string.Empty;
        }

        [Required]
        public string Username { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
    }

    public class LoginViewModel
    {
        public LoginViewModel()
        {
            Username = string.Empty;
            Password = string.Empty;
        }

        [Required]
        public string Username { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
