using animal_service.ViewModels;
using MediatR;

namespace animal_service.Handlers.UserController.Put;

/// <inheritdoc />
public class UpdateRoleCommand : IRequest<RoleViewModelSummary>
{
    public Guid RoleId { get; set; }
    public string Name { get; set; }
}