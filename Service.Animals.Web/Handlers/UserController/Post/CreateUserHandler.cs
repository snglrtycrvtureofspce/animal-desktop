using FluentValidation;
using MediatR;
using Service.Animals.Web.Data;
using Service.Animals.Web.Data.Entities;
using Service.Animals.Web.ViewModels;

namespace Service.Animals.Web.Handlers.UserController.Post;

public class CreateUserHandler : IRequestHandler<CreateUserCommand, UserViewModel>
{
    private readonly AnimalsDbContext _context;
    private readonly IValidator<CreateUserCommand> _validator;
    
    public CreateUserHandler(AnimalsDbContext context, IValidator<CreateUserCommand> validator)
    {
        _context = context;
        _validator = validator;
    }

    public async Task<UserViewModel> Handle(CreateUserCommand request, CancellationToken cancellationToken)
    {
        var validationResult = await _validator.ValidateAsync(request, cancellationToken);

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
            Roles = new List<RoleEntity>(),
            Animals = new List<AnimalEntity>()
        };

        _context.Users.Add(newUser);
        await _context.SaveChangesAsync(cancellationToken);
        
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