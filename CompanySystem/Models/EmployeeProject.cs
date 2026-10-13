using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CompanySystem.Models
{
    public class EmployeeProject
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey(nameof(EmployeeId))]
        [Required]
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
        [ForeignKey(nameof(ProjectId))]
        public int ProjectId { get; set; }
        public Project Project { get; set; }

        [Required, MaxLength(50)]
        public string AssignedRole { get; set; }
        [Required]
        public DateTime AssignedDate {  get; set; }
    }
}
