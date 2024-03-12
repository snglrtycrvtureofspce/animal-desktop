using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using snglrtycrvtureofspce.Animal.Data;
using snglrtycrvtureofspce.Animal.ViewModels;

namespace snglrtycrvtureofspce.Animal.Handlers.RoleController.Get;

public class GetRoleByIdHandler : IRequestHandler<GetRoleByIdQuery, RoleViewModel>
{
    private readonly AnimalsDbContext _context;
    private readonly IMapper _mapper;

    public GetRoleByIdHandler(AnimalsDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<RoleViewModel> Handle(GetRoleByIdQuery request, CancellationToken cancellationToken)
    {
        var user = await _context.Roles
            .Include(u => u.Users)
            .FirstOrDefaultAsync(u => u.Id == request.RoleId, cancellationToken: cancellationToken);

        if (user == null)
        {
            throw new Exception($"Role with ID {request.RoleId} not found");
        }

        return _mapper.Map<RoleViewModel>(user);
    }
}