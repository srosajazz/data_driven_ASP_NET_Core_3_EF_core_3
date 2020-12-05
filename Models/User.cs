using System.ComponentModel.DataAnnotations;

namespace Backoffice.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "This field is require")]
        [MaxLength(20, ErrorMessage = "This field must have between 3 & 60 Characters")]
        [MinLength(3, ErrorMessage = "This field must have between 3 & 60 Characters")]
        public string Username { get; set; }

        [Required(ErrorMessage = "This field is require")]
        [MaxLength(20, ErrorMessage = "This field must have between 3 & 60 Characters")]
        [MinLength(3, ErrorMessage = "This field must have between 3 & 60 Characters")]
        public string Password { get; set; }

        public string Role { get; set; }
    }
}