using animal_service.Data;
using animal_service.ViewModels;
using FluentValidation;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace animal_service.Handlers.RoleController.Put;

/// <summary>
/// Handler for the UpdateRole method
/// </summary>
public class UpdateRoleHandler : IRequestHandler<UpdateRoleCommand, RoleViewModelSummary>
{
    private readonly AnimalsDbContext _context;
    private readonly IValidator<UpdateRoleCommand> _validator;

    /// <summary>
    /// Constructor with params for UpdateUserHandler
    /// </summary>
    /// <param name="context"></param>
    /// <param name="validator"></param>
    public UpdateRoleHandler(AnimalsDbContext context, IValidator<UpdateRoleCommand> validator)
    {
        _context = context;
        _validator = validator;
    }

    /// <inheritdoc />
    public async Task<RoleViewModelSummary> Handle(UpdateRoleCommand request, CancellationToken cancellationToken)
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
        
        return new RoleViewModelSummary
        {
            Id = user.Id,
            CreatedDate = user.CreatedDate,
            ModificationDate = user.ModificationDate,
            Name = user.Name
        };
    }
}