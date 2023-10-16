using MediatR;

namespace animal_service.Handlers.UserController.Delete;

/// <inheritdoc />
public class DeleteUserCommand : IRequest<bool>
{
    public Guid UserId { get; set; }
}