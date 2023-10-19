using System.ComponentModel.DataAnnotations;

namespace RepositoryPatternSample.DTO
{
    public class UserDTO
    {
        public string UserId { get; set; }

        public string Password { get; set; }

        public string Email { get; set; }

        public string MobileNumber { get; set; }

        public string FirstName { get; set; }

        public string? MiddleName { get; set; }

        public string LastName { get; set; }

    }
}
