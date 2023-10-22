using MediatR;

namespace Service.Animals.Web.Handlers.UserController.Delete;

/// <inheritdoc />
public class DeleteUserCommand : IRequest<bool>
{
    public Guid UserId { get; set; }
}