using MediatR;
using Service.Animals.Web.ViewModels;

namespace Service.Animals.Web.Handlers.UserController.Post;

/// <inheritdoc />
public class CreateUserCommand : IRequest<UserViewModel>
{
    public string Username { get; set; }
    public string Password { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public string Email { get; set; }
}