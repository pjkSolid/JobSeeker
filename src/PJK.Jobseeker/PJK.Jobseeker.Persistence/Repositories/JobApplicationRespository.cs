using PJK.Jobseeker.Application.Contracts.Persistence;
using PJK.Jobseeker.Domain.Entities;

namespace PJK.Jobseeker.Persistence.Repositories;

public class JobApplicationRespository : BaseRepository<JobApplication>, IJobApplicationRespository
{
    public JobApplicationRespository(JobseekerDbContext dbContext) : base(dbContext)
    {
    }
}