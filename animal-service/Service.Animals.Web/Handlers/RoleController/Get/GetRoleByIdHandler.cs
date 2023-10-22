using animal_service.Data;
using animal_service.ViewModels;
using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace animal_service.Handlers.RoleController.Get;

/// <summary>
/// Handler for the GetRoleById method
/// </summary>
public class GetRoleByIdHandler : IRequestHandler<GetRoleByIdQuery, RoleViewModelSummary>
{
    private readonly AnimalsDbContext _context;
    private readonly IMapper _mapper;
    
    /// <summary>
    /// Constructor with params for GetRoleByIdHandler
    /// </summary>
    /// <param name="context"></param>
    /// <param name="mapper"></param>
    public GetRoleByIdHandler(AnimalsDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    /// <inheritdoc />
    public async Task<RoleViewModelSummary> Handle(GetRoleByIdQuery request, CancellationToken cancellationToken)
    {
        var user = await _context.Roles
            .Include(u => u.Users)
            .FirstOrDefaultAsync(u => u.Id == request.RoleId, cancellationToken: cancellationToken);

        if (user == null)
        {
            throw new Exception($"Role with ID {request.RoleId} not found");
        }

        return _mapper.Map<RoleViewModelSummary>(user);
    }
}