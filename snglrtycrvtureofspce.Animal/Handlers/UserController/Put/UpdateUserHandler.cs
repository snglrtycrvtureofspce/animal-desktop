using FluentValidation;
using MediatR;
using Microsoft.EntityFrameworkCore;
using snglrtycrvtureofspce.Animal.Data;
using snglrtycrvtureofspce.Animal.ViewModels;

namespace snglrtycrvtureofspce.Animal.Handlers.UserController.Put;

public class UpdateUserHandler(AnimalsDbContext context, IValidator<UpdateUserCommand> validator) 
    : IRequestHandler<UpdateUserCommand, UserViewModel>
{
    public async Task<UserViewModel> Handle(UpdateUserCommand request, CancellationToken cancellationToken)
    {
        var validationResult = await validator.ValidateAsync(request, cancellationToken);

        if (!validationResult.IsValid)
        {
            throw new ValidationException(validationResult.Errors);
        }

        var user = await context.Users.FirstOrDefaultAsync(u => u.Id == request.UserId,
            cancellationToken: cancellationToken);

        if (user == null)
        {
            throw new Exception($"User with ID {request.UserId} not found");
        }

        user.Username = request.Username;
        user.Password = request.Password;
        user.Name = request.Name;
        user.Age = request.Age;
        user.Email = request.Email;

        await context.SaveChangesAsync(cancellationToken);

        return new UserViewModel
        {
            Id = user.Id,
            Name = user.Name,
            Age = user.Age,
            Email = user.Email,
            Roles = new List<RoleViewModel>()
        };
    }
}