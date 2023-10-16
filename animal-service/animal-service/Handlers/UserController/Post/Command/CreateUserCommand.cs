using animal_service.ViewModels;
using MediatR;

namespace animal_service.Handlers.UserController.Post.Command;

/// <inheritdoc />
public class CreateUserCommand : IRequest<UserViewModelSummary>
{
    public string Username { get; set; }
    public string Password { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public string Email { get; set; }
}