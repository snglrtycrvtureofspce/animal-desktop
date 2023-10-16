using MediatR;

namespace animal_service.Handlers.UserController.Post.Command;

/// <inheritdoc />
public class AddUserRoleCommand : IRequest<Unit>
{
    public Guid UserId { get; set; }
    public Guid RoleId { get; set; }
}