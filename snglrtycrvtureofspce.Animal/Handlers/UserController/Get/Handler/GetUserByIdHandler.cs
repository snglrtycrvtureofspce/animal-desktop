using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using snglrtycrvtureofspce.Animal.Data;
using snglrtycrvtureofspce.Animal.Handlers.UserController.Get.Query;
using snglrtycrvtureofspce.Animal.ViewModels;

namespace snglrtycrvtureofspce.Animal.Handlers.UserController.Get.Handler;

public class GetUserByIdHandler(AnimalsDbContext context, IMapperBase mapper) : IRequestHandler<GetUserByIdQuery, 
    UserViewModel>
{
    public async Task<UserViewModel> Handle(GetUserByIdQuery request, CancellationToken cancellationToken)
    {
        var user = await context.Users
            .Include(u => u.Roles)
            .FirstOrDefaultAsync(u => u.Id == request.UserId, cancellationToken: cancellationToken);

        if (user == null)
        {
            throw new Exception($"User with ID {request.UserId} not found");
        }

        return mapper.Map<UserViewModel>(user);
    }
}