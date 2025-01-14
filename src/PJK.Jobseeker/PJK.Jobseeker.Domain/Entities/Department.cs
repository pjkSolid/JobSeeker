using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using PJK.Jobseeker.Domain.Common;

namespace PJK.Jobseeker.Domain.Entities;

public class Department : AuditableEntity
{
    [Key]
    [Required(ErrorMessage = "Department ID is required.")]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)] 
    public int DepartmentId { get; set; }
        
    [Required(ErrorMessage = "Department Name is required.")]
    [StringLength(100, ErrorMessage = "Department Name cannot be longer than 100 characters.")]
    public string DepartmentName { get; set; }
}