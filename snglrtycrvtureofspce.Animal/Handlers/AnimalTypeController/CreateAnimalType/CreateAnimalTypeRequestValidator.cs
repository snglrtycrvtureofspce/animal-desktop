using FluentValidation;

namespace snglrtycrvtureofspce.Animal.Handlers.AnimalTypeController.CreateAnimalType;

public class CreateAnimalTypeRequestValidator : AbstractValidator<CreateAnimalTypeRequest>
{
    public CreateAnimalTypeRequestValidator()
    {
        RuleFor(command => command.Name)
            .NotNull().WithMessage("Name cannot be null.")
            .NotEmpty().WithMessage("Name cannot be empty.");

        RuleFor(command => command.Description)
            .NotNull().WithMessage("Description cannot be null.")
            .NotEmpty().WithMessage("Description cannot be empty.");
    }
}