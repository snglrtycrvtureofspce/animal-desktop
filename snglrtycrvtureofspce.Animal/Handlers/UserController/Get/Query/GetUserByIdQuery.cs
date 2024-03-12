using MediatR;
using snglrtycrvtureofspce.Animal.ViewModels;

namespace snglrtycrvtureofspce.Animal.Handlers.UserController.Get.Query;

public class GetUserByIdQuery : IRequest<UserViewModel>
{
    public Guid UserId { get; init; }
}