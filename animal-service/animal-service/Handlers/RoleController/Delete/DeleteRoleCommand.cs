using MediatR;

namespace animal_service.Handlers.RoleController.Delete;

/// <inheritdoc />
public class DeleteRoleCommand : IRequest<bool>
{
    public Guid RoleId { get; set; }
}