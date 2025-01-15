using PJK.Jobseeker.Application.Features.JobPostings;

namespace PJK.Jobseeker.Application.Contracts.Features;

public interface IJobPostingService
{
    public Task<List<JobPostingListVm>> GetAllJobPostings();
}