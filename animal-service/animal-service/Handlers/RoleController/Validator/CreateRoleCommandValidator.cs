using animal_service.Handlers.RoleController.Post.Command;
using FluentValidation;

namespace animal_service.Handlers.RoleController.Validator;

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