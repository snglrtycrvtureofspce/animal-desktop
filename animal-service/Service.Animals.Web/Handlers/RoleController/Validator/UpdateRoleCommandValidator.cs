using FluentValidation;
using Service.Animals.Web.Handlers.RoleController.Put;

namespace Service.Animals.Web.Handlers.RoleController.Validator;

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