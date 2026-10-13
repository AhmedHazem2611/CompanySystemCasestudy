using CompanySystem.Models;
using System.ComponentModel.DataAnnotations;

namespace CompanySystem.DTOs
{
    public class DepartmentDTO
    {
        [Key]
        public int Id { get; set; }
        [Required, MaxLength(100)]
        public string Name { get; set; }
        [Required, MaxLength(100)]
        public string Location { get; set; }
    }
}
