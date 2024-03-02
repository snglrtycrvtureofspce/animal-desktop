using FluentValidation;

namespace Service.Animals.Web.Handlers.AnimalController.CreateAnimal;

public class CreateAnimalRequestValidator : AbstractValidator<CreateAnimalRequest>
{
    public CreateAnimalRequestValidator()
    {
        RuleFor(command => command.Name)
            .NotNull().WithMessage("Name cannot be null.")
            .NotEmpty().WithMessage("Name cannot be empty.");
        
        RuleFor(command => command.PhotoUrl)
            .NotNull().WithMessage("PhotoUrl cannot be null.")
            .NotEmpty().WithMessage("PhotoUrl cannot be empty.");
        
        RuleFor(command => command.DateOfBirth)
            .NotNull().WithMessage("DateOfBirth cannot be null.")
            .NotEmpty().WithMessage("DateOfBirth cannot be empty.");
        
        RuleFor(command => command.Description)
            .NotNull().WithMessage("Description cannot be null.")
            .NotEmpty().WithMessage("Description cannot be empty.");
        
        RuleFor(command => command.Status)
            .NotNull().WithMessage("Status cannot be null.")
            .NotEmpty().WithMessage("Status cannot be empty.");
        
        RuleFor(command => command.Breed)
            .NotNull().WithMessage("Breed cannot be null.")
            .NotEmpty().WithMessage("Breed cannot be empty.");
    }
}