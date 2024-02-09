using FluentValidation;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Service.Animals.Web.Data;
using Service.Animals.Web.ViewModels;

namespace Service.Animals.Web.Handlers.RoleController.Put;

public class UpdateRoleHandler : IRequestHandler<UpdateRoleCommand, RoleViewModel>
{
    private readonly AnimalsDbContext _context;
    private readonly IValidator<UpdateRoleCommand> _validator;

    public UpdateRoleHandler(AnimalsDbContext context, IValidator<UpdateRoleCommand> validator)
    {
        _context = context;
        _validator = validator;
    }

    public async Task<RoleViewModel> Handle(UpdateRoleCommand request, CancellationToken cancellationToken)
    {
        var validationResult = await _validator.ValidateAsync(request, cancellationToken);

        if (!validationResult.IsValid)
        {
            throw new ValidationException(validationResult.Errors);
        }
        
        var user = await _context.Roles.FirstOrDefaultAsync(u => u.Id == request.RoleId,
            cancellationToken: cancellationToken);

        if (user == null)
        {
            throw new Exception($"Role with ID {request.RoleId} not found");
        }
        
        user.ModificationDate = DateTime.Now;
        user.Name = request.Name;
        
        await _context.SaveChangesAsync(cancellationToken);
        
        return new RoleViewModel
        {
            Id = user.Id,
            CreatedDate = user.CreatedDate,
            ModificationDate = user.ModificationDate,
            Name = user.Name
        };
    }
}