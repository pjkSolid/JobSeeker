using PJK.Jobseeker.Application.Contracts.Persistence;
using PJK.Jobseeker.Domain.Entities;

namespace PJK.Jobseeker.Persistence.Repositories;

public class DepartmentRepository : BaseRepository<Department>, IDepartmentRepository
{
    public DepartmentRepository(JobseekerDbContext dbContext) : base(dbContext)
    {
        
    }
}
