using FluentValidation;
using snglrtycrvtureofspce.Animal.Handlers.RoleController.Post.Command;

namespace snglrtycrvtureofspce.Animal.Handlers.RoleController.Validator;

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