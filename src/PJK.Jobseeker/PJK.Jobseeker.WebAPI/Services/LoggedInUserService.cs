using System.Security.Claims;
using PJK.Jobseeker.Application.Contracts;

namespace PJK.Jobseeker.WebAPI.Services;

public class LoggedInUserService : ILoggedInUserService
{
    private readonly IHttpContextAccessor _contextAccessor;
    public LoggedInUserService(IHttpContextAccessor httpContextAccessor)
    {
        _contextAccessor = httpContextAccessor;
    }

    public string UserId
    {
        get
        {
            return _contextAccessor.HttpContext?.User?.FindFirstValue(ClaimTypes.NameIdentifier);
        }
    }
}