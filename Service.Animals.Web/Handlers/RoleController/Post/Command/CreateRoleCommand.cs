using MediatR;
using Service.Animals.Web.ViewModels;

namespace Service.Animals.Web.Handlers.RoleController.Post.Command;

/// <inheritdoc />
public class CreateRoleCommand: IRequest<RoleViewModel>
{
    public string Name { get; set; }
}