using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using PJK.Jobseeker.Domain.Common;

namespace PJK.Jobseeker.Domain.Entities;

    public class JobApplication : AuditableEntity
    {
        [Key]
        [Required(ErrorMessage = "Application ID is required.")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ApplicationId { get; set; }

        [Required(ErrorMessage = "First Name is required.")]
        [StringLength(100, MinimumLength = 1, ErrorMessage = "Please enter a first name between 1-100 characters.")]
        public string FirstName { get; set; } = null!;

        [Required(ErrorMessage = "Last Name is required.")]
        [StringLength(100, MinimumLength = 1, ErrorMessage = "Please enter a last name between 1-100 characters.")]
        public string LastName { get; set; } = null!;

        [Required(ErrorMessage = "Address is required.")]
        [StringLength(200, MinimumLength = 1, ErrorMessage = "Please enter an address between 1-200 characters.")]
        public string Address { get; set; } = null!;
        
        [Display(Name = "Number (Optional)")]
        [StringLength(15, ErrorMessage = "Number cannot exceed 15 digits.")]
        public string? Number { get; set; }

        [Required(ErrorMessage = "Application Question is required.")]
        [StringLength(500, MinimumLength = 1, ErrorMessage = "Please enter your response between 1-500 characters.")]
        public string ApplicationQuestion { get; set; } = null!;

        // // CV upload - optional field
        // [ValidateNever]
        // [NotMapped]
        // public IFormFile? CVFile { get; set; }
        //
        // // Foreign key to associated JobPosting
        // [Required(ErrorMessage = "Associated Job Posting ID is required.")]
        // [ForeignKey("JobPosting")]
        // public int JobPostingId { get; set; }
        //
        // [ValidateNever]
        // public JobPosting JobPosting { get; set; } = null!;
        //
        // Status of the application - Draft or Submitted
        public enum ApplicationStatus
        {
            Draft,
            Submitted
        }

        [Required]
        public ApplicationStatus Status { get; set; } = ApplicationStatus.Draft;

        // Timestamps
        [Required]
        public DateTime DateCreated { get; set; } = DateTime.UtcNow;

        public DateTime? DateSubmitted { get; set; }
    }