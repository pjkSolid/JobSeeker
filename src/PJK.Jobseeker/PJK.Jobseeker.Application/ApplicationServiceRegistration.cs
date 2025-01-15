using Microsoft.Extensions.DependencyInjection;
using PJK.Jobseeker.Application.Contracts.Features;
using PJK.Jobseeker.Application.Features.JobPostings;

namespace PJK.Jobseeker.Application;

public static class ApplicationServiceRegistration
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
        services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(AppDomain.CurrentDomain.GetAssemblies()));

        services.AddScoped<IJobPostingService, JobPostingService>();
        
        return services;
    }
}