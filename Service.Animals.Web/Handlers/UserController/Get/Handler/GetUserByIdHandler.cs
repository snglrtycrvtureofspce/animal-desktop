using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Service.Animals.Web.Data;
using Service.Animals.Web.Handlers.UserController.Get.Query;
using Service.Animals.Web.ViewModels;

namespace Service.Animals.Web.Handlers.UserController.Get.Handler;

/// <summary>
/// Handler for the GetUserById method
/// </summary>
public class GetUserByIdHandler : IRequestHandler<GetUserByIdQuery, UserViewModel>
{
    private readonly AnimalsDbContext _context;
    private readonly IMapper _mapper;
    
    public GetUserByIdHandler(AnimalsDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<UserViewModel> Handle(GetUserByIdQuery request, CancellationToken cancellationToken)
    {
        var user = await _context.Users
            .Include(u => u.Roles)
            .FirstOrDefaultAsync(u => u.Id == request.UserId, cancellationToken: cancellationToken);

        if (user == null)
        {
            throw new Exception($"User with ID {request.UserId} not found");
        }

        return _mapper.Map<UserViewModel>(user);
    }
}