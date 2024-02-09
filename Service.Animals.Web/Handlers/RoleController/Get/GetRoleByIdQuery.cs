using MediatR;
using Service.Animals.Web.ViewModels;

namespace Service.Animals.Web.Handlers.RoleController.Get;

/// <inheritdoc />
public class GetRoleByIdQuery : IRequest<RoleViewModel>
{
    public Guid RoleId { get; set; }
}