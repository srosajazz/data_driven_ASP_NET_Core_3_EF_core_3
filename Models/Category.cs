using System.ComponentModel.DataAnnotations;

namespace Backoffice.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "This field is require")]
        [MaxLength(60, ErrorMessage = "This field must have between 3 & 60 Characters")]
        [MinLength(3, ErrorMessage = "This field must have between 3 & 60 Characters")]
        public string Title { get; set; }
    }
}
