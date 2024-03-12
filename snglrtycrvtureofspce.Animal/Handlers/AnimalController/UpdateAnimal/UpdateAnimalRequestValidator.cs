using FluentValidation;

namespace snglrtycrvtureofspce.Animal.Handlers.AnimalController.UpdateAnimal;

public class UpdateAnimalRequestValidator : AbstractValidator<UpdateAnimalRequest>
{
    public UpdateAnimalRequestValidator()
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