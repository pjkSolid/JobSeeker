using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PJK.Jobseeker.Application.Contracts.Features;
using PJK.Jobseeker.Application.Features.JobPostings;

namespace PJK.Jobseeker.WebAPI.Controllers;


[Route("api/[controller]")]
[ApiController]
public class JobPostingController : ControllerBase
{
    private readonly IJobPostingService _jobPostingService;

    public JobPostingController(IJobPostingService jobPostingService)
    {
        _jobPostingService = jobPostingService;
    }
    
    [HttpGet("all", Name = "GetAllJobPostings")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    //[Authorize]
    public async Task<ActionResult<List<JobPostingListVm>>> GetAllJobPostings()
    {
      var dtos =  _jobPostingService.GetAllJobPostings();
      return Ok(dtos);
    }
    
}