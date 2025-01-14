using PJK.Jobseeker.Application.Contracts.Persistence;
using PJK.Jobseeker.Domain.Entities;

namespace PJK.Jobseeker.Persistence.Repositories;

public class LocationRepository : BaseRepository<Location>, ILocationRepository
{
    public LocationRepository(JobseekerDbContext dbContext) : base(dbContext)
    {
    }
}