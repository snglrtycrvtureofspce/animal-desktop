using FluentValidation;

namespace snglrtycrvtureofspce.Animal.Handlers.LocationController.CreateLocation;

public class CreateLocationRequestValidator : AbstractValidator<CreateLocationRequest>
{
    public CreateLocationRequestValidator()
    {
        RuleFor(command => command.Name)
            .NotNull().WithMessage("Name cannot be null.")
            .NotEmpty().WithMessage("Name cannot be empty.");

        RuleFor(command => command.Description)
            .NotNull().WithMessage("Description cannot be null.")
            .NotEmpty().WithMessage("Description cannot be empty.");
        
        RuleFor(command => command.Latitude)
            .NotNull().WithMessage("Latitude cannot be null.")
            .NotEmpty().WithMessage("Latitude cannot be empty.");
        
        RuleFor(command => command.Longitude)
            .NotNull().WithMessage("Longitude cannot be null.")
            .NotEmpty().WithMessage("Longitude cannot be empty.");
    }
}