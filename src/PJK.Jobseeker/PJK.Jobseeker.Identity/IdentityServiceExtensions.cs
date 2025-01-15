using Microsoft.AspNetCore.Identity;
using PJK.Jobseeker.Identity.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace PJK.Jobseeker.Identity;

public static class IdentityServiceExtensions
{
    public static void AddIdentityServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddAuthentication(IdentityConstants.ApplicationScheme).AddIdentityCookies();

        services.AddAuthorizationBuilder();

        services.AddDbContext<JobseekerIdentityDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("JobseekerIdentityConnectionString")));

        services.AddIdentityCore<ApplicationUser>()
            .AddEntityFrameworkStores<JobseekerIdentityDbContext>()
            .AddApiEndpoints();
    }
}