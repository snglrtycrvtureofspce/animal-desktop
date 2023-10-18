using animal_service.Data;
using animal_service.Models;
using animal_service.ViewModels;
using FluentValidation;
using MediatR;

namespace animal_service.Handlers.UserController.Post;

/// <summary>
/// Handler for the CreateUser method
/// </summary>
public class CreateUserHandler : IRequestHandler<CreateUserCommand, UserViewModelSummary>
{
    private readonly AnimalsDbContext _context;
    private readonly IValidator<CreateUserCommand> _validator;

    /// <summary>
    /// Constructor with params for CreateUserHandler
    /// </summary>
    /// <param name="context"></param>
    /// <param name="validator"></param>
    public CreateUserHandler(AnimalsDbContext context, IValidator<CreateUserCommand> validator)
    {
        _context = context;
        _validator = validator;
    }

    /// <inheritdoc />
    public async Task<UserViewModelSummary> Handle(CreateUserCommand request, CancellationToken cancellationToken)
    {
        var validationResult = await _validator.ValidateAsync(request, cancellationToken);

        if (!validationResult.IsValid)
        {
            throw new ValidationException(validationResult.Errors);
        }
        
        var newUser = new UserEntity()
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
        
        return new UserViewModelSummary
        {
            Id = newUser.Id,
            CreatedDate = newUser.CreatedDate,
            ModificationDate = newUser.ModificationDate,
            Username = newUser.Username,
            Password = newUser.Password,
            Name = newUser.Name,
            Age = newUser.Age,
            Email = newUser.Email,
            Roles = new List<RoleViewModelSummary>()
        };
    }
}