using FluentValidation;
using MediatR;
using Service.Animals.Web.Data;
using Service.Animals.Web.Data.Entities;
using Service.Animals.Web.Handlers.RoleController.Post.Command;
using Service.Animals.Web.ViewModels;

namespace Service.Animals.Web.Handlers.RoleController.Post.Handler;

public class CreateRoleHandler : IRequestHandler<CreateRoleCommand, RoleViewModel>
{
    private readonly AnimalsDbContext _context;
    private readonly IValidator<CreateRoleCommand> _validator;
    
    public CreateRoleHandler(AnimalsDbContext context, IValidator<CreateRoleCommand> validator)
    {
        _context = context;
        _validator = validator;
    }
    
    public async Task<RoleViewModel> Handle(CreateRoleCommand request, CancellationToken cancellationToken)
    {
        var validationResult = await _validator.ValidateAsync(request, cancellationToken);

        if (!validationResult.IsValid)
        {
            throw new ValidationException(validationResult.Errors);
        }
        
        var newRole = new RoleEntity
        {
            Id = Guid.NewGuid(),
            CreatedDate = DateTime.Now,
            ModificationDate = DateTime.Now,
            Name = request.Name,
            Users = new List<UserEntity>()
        };

        _context.Roles.Add(newRole);
        await _context.SaveChangesAsync(cancellationToken);
        
        return new RoleViewModel
        {
            Id = newRole.Id,
            CreatedDate = newRole.CreatedDate,
            ModificationDate = newRole.ModificationDate,
            Name = newRole.Name,
            Users = new List<UserViewModel>()
        };
    }
}