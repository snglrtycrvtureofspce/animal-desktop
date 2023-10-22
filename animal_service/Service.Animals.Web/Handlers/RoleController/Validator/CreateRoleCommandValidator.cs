using FluentValidation;
using Service.Animals.Web.Handlers.RoleController.Post.Command;

namespace Service.Animals.Web.Handlers.RoleController.Validator;

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