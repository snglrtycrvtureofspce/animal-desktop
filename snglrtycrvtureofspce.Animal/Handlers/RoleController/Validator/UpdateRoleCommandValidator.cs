using FluentValidation;
using snglrtycrvtureofspce.Animal.Handlers.RoleController.Put;

namespace snglrtycrvtureofspce.Animal.Handlers.RoleController.Validator;

/// <summary>
/// Data validator for the role update method
/// </summary>
public class UpdateRoleCommandValidator : AbstractValidator<UpdateRoleCommand>
{
    /// <inheritdoc />
    public UpdateRoleCommandValidator()
    {
        RuleFor(command => command.Name).NotEmpty().WithMessage("Name is required.");
    }
}