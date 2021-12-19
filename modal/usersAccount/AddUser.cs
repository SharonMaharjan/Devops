using System.ComponentModel.DataAnnotations;

namespace DevopsAssignment.Models.Account
{
    public class AddUser
    {
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string Username { get; set; }

        [Required]
        [MinLength(6, ErrorMessage = "Here should be atleast 6 characters")]
            public string Password { get; set; }
    }
}