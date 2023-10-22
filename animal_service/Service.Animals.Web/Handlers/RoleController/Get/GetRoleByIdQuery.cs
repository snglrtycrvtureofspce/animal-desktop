using MediatR;
using Service.Animals.Api.ViewModels;

namespace Service.Animals.Web.Handlers.RoleController.Get;

/// <inheritdoc />
public class GetRoleByIdQuery : IRequest<RoleViewModelSummary>
{
    public Guid RoleId { get; set; }
}