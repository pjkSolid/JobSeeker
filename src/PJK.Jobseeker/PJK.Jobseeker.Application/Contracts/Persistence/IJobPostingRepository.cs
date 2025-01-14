using PJK.Jobseeker.Domain.Entities;

namespace PJK.Jobseeker.Application.Contracts.Persistence;

public interface IJobPostingRepository : IAsyncRepository<JobPosting>
{
    
}