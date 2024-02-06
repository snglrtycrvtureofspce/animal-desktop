using MediatR;
using Service.Animals.Web.ViewModels;

namespace Service.Animals.Web.Handlers.UserController.Put;

/// <inheritdoc />
public class UpdateUserCommand : IRequest<UserViewModelSummary>
{
    public Guid UserId { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public string Email { get; set; }
}