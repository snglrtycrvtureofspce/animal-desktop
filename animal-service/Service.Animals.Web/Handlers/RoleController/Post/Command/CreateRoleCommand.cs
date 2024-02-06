using MediatR;
using Service.Animals.Api.ViewModels;

namespace Service.Animals.Web.Handlers.RoleController.Post.Command;

/// <inheritdoc />
public class CreateRoleCommand: IRequest<RoleViewModelSummary>
{
    public string Name { get; set; }
}