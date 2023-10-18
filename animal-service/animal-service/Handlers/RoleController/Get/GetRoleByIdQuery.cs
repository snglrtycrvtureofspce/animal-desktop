using animal_service.ViewModels;
using MediatR;

namespace animal_service.Handlers.RoleController.Get;

/// <inheritdoc />
public class GetRoleByIdQuery : IRequest<RoleViewModelSummary>
{
    public Guid RoleId { get; set; }
}