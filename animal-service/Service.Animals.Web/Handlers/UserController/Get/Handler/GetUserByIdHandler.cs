using animal_service.Data;
using animal_service.Handlers.UserController.Get.Query;
using animal_service.ViewModels;
using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace animal_service.Handlers.UserController.Get.Handler;

/// <summary>
/// Handler for the GetUserById method
/// </summary>
public class GetUserByIdHandler : IRequestHandler<GetUserByIdQuery, UserViewModelSummary>
{
    private readonly AnimalsDbContext _context;
    private readonly IMapper _mapper;
    
    /// <summary>
    /// Constructor with params for GetUserByIdHandler
    /// </summary>
    /// <param name="context"></param>
    /// <param name="mapper"></param>
    public GetUserByIdHandler(AnimalsDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    /// <inheritdoc />
    public async Task<UserViewModelSummary> Handle(GetUserByIdQuery request, CancellationToken cancellationToken)
    {
        var user = await _context.Users
            .Include(u => u.Roles)
            .FirstOrDefaultAsync(u => u.Id == request.UserId, cancellationToken: cancellationToken);

        if (user == null)
        {
            throw new Exception($"User with ID {request.UserId} not found");
        }

        return _mapper.Map<UserViewModelSummary>(user);
    }
}