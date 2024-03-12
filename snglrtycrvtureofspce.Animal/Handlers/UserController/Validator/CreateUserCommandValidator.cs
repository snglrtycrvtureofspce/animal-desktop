using FluentValidation;
using snglrtycrvtureofspce.Animal.Handlers.UserController.Post;

namespace snglrtycrvtureofspce.Animal.Handlers.UserController.Validator;

public class CreateUserCommandValidator : AbstractValidator<CreateUserCommand>
{
    public CreateUserCommandValidator()
    {
        RuleFor(command => command.Name)
            .NotEmpty()
            .WithMessage("Name is required.");
        
        RuleFor(command => command.Age)
            .GreaterThan(0)
            .WithMessage("Age must be a positive number.");
        
        RuleFor(command => command.Email)
            .NotEmpty()
            .WithMessage("Email is required.")
            .EmailAddress()
            .WithMessage("Invalid email format.");
    }
}