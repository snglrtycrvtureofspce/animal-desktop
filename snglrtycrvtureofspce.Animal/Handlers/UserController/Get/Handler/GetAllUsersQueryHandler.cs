using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using snglrtycrvtureofspce.Animal.Data;
using snglrtycrvtureofspce.Animal.Data.Entities;
using snglrtycrvtureofspce.Animal.Handlers.UserController.Get.Query;
using snglrtycrvtureofspce.Animal.ViewModels;
using snglrtycrvtureofspce.Core.Helpers;

namespace snglrtycrvtureofspce.Animal.Handlers.UserController.Get.Handler;

public class GetAllUsersQueryHandler(AnimalsDbContext context, IMapperBase mapper) : IRequestHandler<GetAllUsersQuery, 
    IEnumerable<UserViewModel>>
{
    public async Task<IEnumerable<UserViewModel>> Handle(GetAllUsersQuery request, CancellationToken cancellationToken)
    {
        var query = context.Users
            .Include(u => u.Roles)
            .AsQueryable();

        if (!string.IsNullOrWhiteSpace(request.Filter))
        {
            query = query.Where(u => u.Name.Contains(request.Filter) || u.Email.Contains(request.Filter) ||
                                     u.Roles.Any(r => r.Name.Contains(request.Filter)));
        }

        if (!string.IsNullOrWhiteSpace(request.SortBy))
        {
            var sortLambda = ExpressionHelpers.GetSortLambda<UserEntity>(request.SortBy);
            query = query.OrderBy(sortLambda);
        }

        query = query.Skip((request.Page - 1) * request.PageSize)
            .Take(request.PageSize);

        return await query
            .Select(u => mapper.Map<UserViewModel>(u))
            .ToListAsync(cancellationToken);
    }
}