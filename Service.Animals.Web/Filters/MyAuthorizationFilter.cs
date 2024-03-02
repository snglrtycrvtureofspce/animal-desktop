using Hangfire.Dashboard;

namespace Service.Animals.Web.Filters;

public class MyAuthorizationFilter : IDashboardAuthorizationFilter
{
    public bool Authorize(DashboardContext context)
    {
        return true;
    }
}