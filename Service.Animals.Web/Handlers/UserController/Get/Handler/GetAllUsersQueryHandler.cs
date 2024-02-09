using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Service.Animals.Web.Data;
using Service.Animals.Web.Data.Entities;
using Service.Animals.Web.Handlers.UserController.Get.Query;
using Service.Animals.Web.ViewModels;
using snglrtycrvtureofspce.Core.Helpers;

namespace Service.Animals.Web.Handlers.UserController.Get.Handler;

public class GetAllUsersQueryHandler : IRequestHandler<GetAllUsersQuery, IEnumerable<UserViewModel>>
{
    private readonly AnimalsDbContext _context;
    private readonly IMapper _mapper;
    
    public GetAllUsersQueryHandler(AnimalsDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<IEnumerable<UserViewModel>> Handle(GetAllUsersQuery request, CancellationToken cancellationToken)
    {
        var query = _context.Users
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
            .Select(u => _mapper.Map<UserViewModel>(u))
            .ToListAsync(cancellationToken);
    }
}