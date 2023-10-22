using FluentValidation;
using MediatR;
using Service.Animals.Api.ViewModels;
using Service.Animals.Web.Data;
using Service.Animals.Web.Handlers.RoleController.Post.Command;
using Service.Animals.Web.Models;

namespace Service.Animals.Web.Handlers.RoleController.Post.Handler;

/// <summary>
/// Handler for the CreateRole method
/// </summary>
public class CreateRoleHandler : IRequestHandler<CreateRoleCommand, RoleViewModelSummary>
{
    private readonly AnimalsDbContext _context;
    private readonly IValidator<CreateRoleCommand> _validator;

    /// <summary>
    /// Constructor with params for CreateRoleHandler
    /// </summary>
    /// <param name="context"></param>
    /// <param name="validator"></param>
    public CreateRoleHandler(AnimalsDbContext context, IValidator<CreateRoleCommand> validator)
    {
        _context = context;
        _validator = validator;
    }
    
    /// <inheritdoc />
    public async Task<RoleViewModelSummary> Handle(CreateRoleCommand request, CancellationToken cancellationToken)
    {
        var validationResult = await _validator.ValidateAsync(request, cancellationToken);

        if (!validationResult.IsValid)
        {
            throw new ValidationException(validationResult.Errors);
        }
        
        var newRole = new RoleEntity()
        {
            Id = Guid.NewGuid(),
            CreatedDate = DateTime.Now,
            ModificationDate = DateTime.Now,
            Name = request.Name,
            Users = new List<UserEntity>()
        };

        _context.Roles.Add(newRole);
        await _context.SaveChangesAsync(cancellationToken);
        
        return new RoleViewModelSummary
        {
            Id = newRole.Id,
            CreatedDate = newRole.CreatedDate,
            ModificationDate = newRole.ModificationDate,
            Name = newRole.Name,
            Users = new List<UserViewModelSummary>()
        };
    }
}