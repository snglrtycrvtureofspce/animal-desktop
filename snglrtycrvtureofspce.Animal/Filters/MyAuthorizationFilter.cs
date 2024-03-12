using Hangfire.Dashboard;

namespace snglrtycrvtureofspce.Animal.Filters;

public class MyAuthorizationFilter : IDashboardAuthorizationFilter
{
    public bool Authorize(DashboardContext context)
    {
        return true;
    }
}