using MediatR;

namespace snglrtycrvtureofspce.Animal.Handlers.UserController.Delete;

public class DeleteUserCommand : IRequest<bool>
{
    public Guid UserId { get; set; }
}