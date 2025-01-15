using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PJK.Jobseeker.Identity.Models;

namespace PJK.Jobseeker.Identity;

public class JobseekerIdentityDbContext : IdentityDbContext<ApplicationUser>
{
    public JobseekerIdentityDbContext()
    {
        
    }
    
    public JobseekerIdentityDbContext(DbContextOptions<JobseekerIdentityDbContext> options) : base(options)
    {
    }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder
            .LogTo(Console.WriteLine)
            .EnableSensitiveDataLogging();
}