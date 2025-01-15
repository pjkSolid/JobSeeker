using Microsoft.EntityFrameworkCore;
using PJK.Jobseeker.Application.Contracts;
using PJK.Jobseeker.Domain.Common;
using PJK.Jobseeker.Domain.Entities;

namespace PJK.Jobseeker.Persistence;

public class JobseekerDbContext : DbContext
{
    private readonly ILoggedInUserService? _loggedInUserService;
    
    public JobseekerDbContext(DbContextOptions<JobseekerDbContext> options)
        : base(options)
    {
    }
    public JobseekerDbContext(DbContextOptions<JobseekerDbContext> options, ILoggedInUserService loggedInUserService)
        : base(options)
    {
        _loggedInUserService = loggedInUserService;
    }
    
    public DbSet<Department> Departments { get; set; }
    public DbSet<JobApplication> JobApplications { get; set; }
    public DbSet<JobPosting> JobPostings { get; set; }
    public DbSet<Location> Locations { get; set; }
    
    public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
    {
        foreach (var entry in ChangeTracker.Entries<AuditableEntity>())
        {
            switch (entry.State)
            {
                case EntityState.Added:
                    entry.Entity.CreatedDate = DateTime.Now;
                    break;
                case EntityState.Modified:
                    entry.Entity.LastModifiedDate = DateTime.Now;
                    break;
            }
        }
        return base.SaveChangesAsync(cancellationToken);
    }
}