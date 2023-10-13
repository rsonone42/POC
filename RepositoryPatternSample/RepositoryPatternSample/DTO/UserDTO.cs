using System.ComponentModel.DataAnnotations;

namespace RepositoryPatternSample.DTO
{
    public class UserDTO
    {
        [Required]
        public string UserId { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string MobileNumber { get; set; }

        [Required]
        public string FirstName { get; set; }

        public string? MiddleName { get; set; }

        [Required]
        public string LastName { get; set; }

    }
}
