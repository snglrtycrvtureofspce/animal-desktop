using MediatR;
using Service.Animals.Web.ViewModels;

namespace Service.Animals.Web.Handlers.UserController.Get.Query;

/// <inheritdoc />
public class GetUserByIdQuery : IRequest<UserViewModelSummary>
{
    public Guid UserId { get; set; }
}