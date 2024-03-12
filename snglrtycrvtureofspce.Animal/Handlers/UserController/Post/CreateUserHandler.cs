using FluentValidation;
using MediatR;
using snglrtycrvtureofspce.Animal.Data;
using snglrtycrvtureofspce.Animal.Data.Entities;
using snglrtycrvtureofspce.Animal.ViewModels;

namespace snglrtycrvtureofspce.Animal.Handlers.UserController.Post;

public class CreateUserHandler(AnimalsDbContext context, IValidator<CreateUserCommand> validator) 
    : IRequestHandler<CreateUserCommand, UserViewModel>
{
    public async Task<UserViewModel> Handle(CreateUserCommand request, CancellationToken cancellationToken)
    {
        var validationResult = await validator.ValidateAsync(request, cancellationToken);

        if (!validationResult.IsValid)
        {
            throw new ValidationException(validationResult.Errors);
        }

        var newUser = new UserEntity
        {
            Id = Guid.NewGuid(),
            CreatedDate = DateTime.Now,
            ModificationDate = DateTime.Now,
            Username = request.Username,
            Password = request.Password,
            Name = request.Name,
            Age = request.Age,
            Email = request.Email,
            Roles = new List<RoleEntity>()
        };

        context.Users.Add(newUser);
        await context.SaveChangesAsync(cancellationToken);

        return new UserViewModel
        {
            Id = newUser.Id,
            CreatedDate = newUser.CreatedDate,
            ModificationDate = newUser.ModificationDate,
            Username = newUser.Username,
            Password = newUser.Password,
            Name = newUser.Name,
            Age = newUser.Age,
            Email = newUser.Email,
            Roles = new List<RoleViewModel>()
        };
    }
}