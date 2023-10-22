using MediatR;

namespace Service.Animals.Web.Handlers.RoleController.Delete;

/// <inheritdoc />
public class DeleteRoleCommand : IRequest<bool>
{
    public Guid RoleId { get; set; }
}