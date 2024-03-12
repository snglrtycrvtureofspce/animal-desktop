using MediatR;
using snglrtycrvtureofspce.Animal.ViewModels;

namespace snglrtycrvtureofspce.Animal.Handlers.RoleController.Get;

/// <inheritdoc />
public class GetRoleByIdQuery : IRequest<RoleViewModel>
{
    public Guid RoleId { get; set; }
}