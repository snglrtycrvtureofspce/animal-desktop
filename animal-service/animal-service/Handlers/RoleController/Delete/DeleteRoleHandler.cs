using animal_service.Data;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace animal_service.Handlers.RoleController.Delete;

/// <summary>
/// Handler for the DeleteRole method
/// </summary>
public class DeleteRoleHandler : IRequestHandler<DeleteRoleCommand, bool>
{
    private readonly AnimalsDbContext _context;
    
    /// <summary>
    /// Constructor with params for DeleteRoleHandler
    /// </summary>
    /// <param name="context"></param>
    public DeleteRoleHandler(AnimalsDbContext context)
    {
        _context = context;
    }

    /// <inheritdoc />
    public async Task<bool> Handle(DeleteRoleCommand request, CancellationToken cancellationToken)
    {
        var role = await _context.Roles.FirstOrDefaultAsync(u => u.Id == request.RoleId,
            cancellationToken: cancellationToken);

        if (role == null)
        {
            throw new Exception($"Role with ID {request.RoleId} not found");
        }

        _context.Roles.Remove(role);
        await _context.SaveChangesAsync(cancellationToken);

        return true;
    }
}