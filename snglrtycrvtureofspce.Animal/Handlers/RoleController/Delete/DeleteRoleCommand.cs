using MediatR;

namespace snglrtycrvtureofspce.Animal.Handlers.RoleController.Delete;

/// <inheritdoc />
public class DeleteRoleCommand : IRequest<bool>
{
    public Guid RoleId { get; set; }
}