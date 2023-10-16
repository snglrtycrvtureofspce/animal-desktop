using MediatR;

namespace animal_service.Handlers.UserController.Delete;

/// <inheritdoc />
public class DeleteRoleCommand : IRequest<bool>
{
    public Guid RoleId { get; set; }
}