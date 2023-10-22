using MediatR;
using Service.Animals.Api.ViewModels;

namespace Service.Animals.Web.Handlers.RoleController.Put;

/// <inheritdoc />
public class UpdateRoleCommand : IRequest<RoleViewModelSummary>
{
    public Guid RoleId { get; set; }
    public string Name { get; set; }
}