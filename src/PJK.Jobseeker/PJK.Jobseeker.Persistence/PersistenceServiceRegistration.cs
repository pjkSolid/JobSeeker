using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PJK.Jobseeker.Application.Contracts.Persistence;
using PJK.Jobseeker.Persistence.Repositories;

namespace PJK.Jobseeker.Persistence;

public static class PersistenceServiceRegistration
{
    public static IServiceCollection AddPersistenceServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<JobseekerDbContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("JobseekerConnectionString")));

        services.AddScoped(typeof(IAsyncRepository<>), typeof(BaseRepository<>));

        services.AddScoped<IDepartmentRepository, DepartmentRepository>();
        services.AddScoped<IJobApplicationRespository, JobApplicationRespository>();
        services.AddScoped<IJobPostingRepository, JobPostingRepository>();
        services.AddScoped<ILocationRepository, LocationRepository>();

        return services;
    }
}