using animal_service.ViewModels;
using MediatR;

namespace animal_service.Handlers.UserController.Get.Query;

/// <inheritdoc />
public class GetUserByIdQuery : IRequest<UserViewModelSummary>
{
    public Guid UserId { get; set; }
}