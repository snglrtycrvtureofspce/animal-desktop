using FluentValidation;

namespace snglrtycrvtureofspce.Animal.Handlers.AnimalController.CreateAnimal;

public class CreateAnimalRequestValidator : AbstractValidator<CreateAnimalRequest>
{
    public CreateAnimalRequestValidator()
    {
        RuleFor(command => command.Name)
            .NotNull().WithMessage("Name cannot be null.")
            .NotEmpty().WithMessage("Name cannot be empty.");

        RuleFor(command => command.Description)
            .NotNull().WithMessage("Description cannot be null.")
            .NotEmpty().WithMessage("Description cannot be empty.");
        
        RuleFor(command => command.AnimalTypeId)
            .NotNull().WithMessage("AnimalTypeId cannot be null.")
            .NotEmpty().WithMessage("AnimalTypeId cannot be empty.");
    }
}