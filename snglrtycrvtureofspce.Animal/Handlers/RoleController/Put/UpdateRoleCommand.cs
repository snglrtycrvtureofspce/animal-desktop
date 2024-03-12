using MediatR;
using snglrtycrvtureofspce.Animal.ViewModels;

namespace snglrtycrvtureofspce.Animal.Handlers.RoleController.Put;

/// <inheritdoc />
public class UpdateRoleCommand : IRequest<RoleViewModel>
{
    public Guid RoleId { get; set; }
    public string Name { get; set; }
}