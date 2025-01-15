using System.ComponentModel.DataAnnotations;

namespace PJK.Jobseeker.Domain.enums;

public enum JobType
{
    [Display(Name = "Full Time")]
    FullTime,
    [Display(Name = "Part Time")]
    PartTime,
    [Display(Name = "Contract")]
    Contract,
    [Display(Name = "Internship")]
    Internship
}