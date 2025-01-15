using PJK.Jobseeker.Application.Contracts.Features;

namespace PJK.Jobseeker.Application.Features.JobPostings;

public class JobPostingService : IJobPostingService
{
    public JobPostingService()
    {
        
    }
    
    public async Task<List<JobPostingListVm>> GetAllJobPostings()
    {
        //TODO --- Plug this into EF 
        var jobPostingListVms = new List<JobPostingListVm>()
        { 
            new JobPostingListVm()
            {
                JobPostingId = 1, JobTitle = "ASP NET Developer"
            }, 
            new JobPostingListVm()
            {
                JobPostingId = 2, JobTitle = "Azure Platform Engineer"
            }
            
        };

        return jobPostingListVms;
    }
}