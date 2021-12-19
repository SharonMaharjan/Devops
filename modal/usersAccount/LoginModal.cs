using System.ComponentModel.DataAnnotations;

namespace DevopsAssignment.Models.Account
{
    public class Login
    {
        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }
    }
}