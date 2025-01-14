using PJK.Jobseeker.Application.Contracts.Persistence;
using PJK.Jobseeker.Domain.Entities;

namespace PJK.Jobseeker.Persistence.Repositories;

public class JobPostingRepository : BaseRepository<JobPosting>, IJobPostingRepository
{
    public JobPostingRepository(JobseekerDbContext dbContext) : base(dbContext)
    {
    }
}