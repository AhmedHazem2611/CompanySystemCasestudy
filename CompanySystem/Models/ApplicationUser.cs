using System.ComponentModel.DataAnnotations;

namespace CompanySystem.Models
{
    public class ApplicationUser
    {
        [Key]
        public int Id { get; set; }
        [Required, MaxLength(100),EmailAddress]
        public string Email {  get; set; }
        [Required, MaxLength (100)]
        public string Password { get; set; }
        [Required , MaxLength (30)]
        public string Role { get; set; }
    }
}
