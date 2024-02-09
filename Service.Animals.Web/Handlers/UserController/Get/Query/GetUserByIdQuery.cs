using MediatR;
using Service.Animals.Web.ViewModels;

namespace Service.Animals.Web.Handlers.UserController.Get.Query;

/// <inheritdoc />
public class GetUserByIdQuery : IRequest<UserViewModel>
{
    public Guid UserId { get; set; }
}