using MediatR;
using snglrtycrvtureofspce.Animal.ViewModels;

namespace snglrtycrvtureofspce.Animal.Handlers.RoleController.Post.Command;

/// <inheritdoc />
public class CreateRoleCommand : IRequest<RoleViewModel>
{
    public string Name { get; set; }
}