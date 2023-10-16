using animal_service.Handlers.UserController.Post.Command;
using FluentValidation;

namespace animal_service.Handlers.UserController.Validator;

/// <summary>
/// Data validator for the role creation method
/// </summary>
public class CreateRoleCommandValidator : AbstractValidator<CreateRoleCommand>
{
    /// <inheritdoc />
    public CreateRoleCommandValidator()
    {
        RuleFor(command => command.Name).NotEmpty().WithMessage("Name is required.");
    }
}