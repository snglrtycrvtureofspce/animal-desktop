using animal_service.Handlers.UserController.Put;
using FluentValidation;

namespace animal_service.Handlers.UserController.Validator;

/// <summary>
/// Data validator for the user update method
/// </summary>
public class UpdateUserCommandValidator : AbstractValidator<UpdateUserCommand>
{
    /// <inheritdoc />
    public UpdateUserCommandValidator()
    {
        RuleFor(command => command.UserId).NotEmpty().WithMessage("Id is required and cannot be set default.")
            .Must(id => id != Guid.Parse("3fa85f64-5717-4562-b3fc-2c963f66afa6"))
            .WithMessage("Id cannot be '3fa85f64-5717-4562-b3fc-2c963f66afa6'");;
        RuleFor(command => command.Name).NotEmpty().WithMessage("Name is required.");
        RuleFor(command => command.Age).GreaterThan(0)
            .WithMessage("Age must be a positive number.");
        RuleFor(command => command.Email)
            .NotEmpty().WithMessage("Email is required.")
            .EmailAddress().WithMessage("Invalid email format.");
    }
}