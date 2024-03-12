using MediatR;
using Microsoft.EntityFrameworkCore;
using snglrtycrvtureofspce.Animal.Data;

namespace snglrtycrvtureofspce.Animal.Handlers.UserController.Delete;

public class DeleteUserHandler(AnimalsDbContext context) : IRequestHandler<DeleteUserCommand, bool>
{
    public async Task<bool> Handle(DeleteUserCommand request, CancellationToken cancellationToken)
    {
        var user = await context.Users.FirstOrDefaultAsync(u => u.Id == request.UserId,
            cancellationToken: cancellationToken);

        if (user == null)
        {
            throw new Exception($"User with ID {request.UserId} not found");
        }

        context.Users.Remove(user);
        await context.SaveChangesAsync(cancellationToken);

        return true;
    }
}