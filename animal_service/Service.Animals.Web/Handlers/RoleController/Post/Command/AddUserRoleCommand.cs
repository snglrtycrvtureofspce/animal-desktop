using MediatR;

namespace Service.Animals.Web.Handlers.RoleController.Post.Command;

/// <inheritdoc />
public class AddUserRoleCommand : IRequest<Unit>
{
    public Guid UserId { get; set; }
    public Guid RoleId { get; set; }
}