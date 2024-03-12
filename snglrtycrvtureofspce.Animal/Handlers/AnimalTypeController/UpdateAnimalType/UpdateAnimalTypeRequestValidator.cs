using FluentValidation;

namespace snglrtycrvtureofspce.Animal.Handlers.AnimalTypeController.UpdateAnimalType;

public class UpdateAnimalTypeRequestValidator : AbstractValidator<UpdateAnimalTypeRequest>
{
    public UpdateAnimalTypeRequestValidator()
    {
        RuleFor(command => command.Name)
            .NotNull().WithMessage("Name cannot be null.")
            .NotEmpty().WithMessage("Name cannot be empty.");

        RuleFor(command => command.Description)
            .NotNull().WithMessage("Description cannot be null.")
            .NotEmpty().WithMessage("Description cannot be empty.");
    }
}