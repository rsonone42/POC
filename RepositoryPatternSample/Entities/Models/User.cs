using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    [Table("enduser")]
    public class User
    {
        [Required(ErrorMessage = "UserId is required")]
        [StringLength(30, ErrorMessage = "UserId cannot be larger then 30 characters")]
        public string UserId { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string MobileNumber { get; set; }

        [Required]
        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public DateTime CreatedDateTime { get; set; }

        public ICollection<UserAddress> UserAddresses { get; set; }

    }
}
