using FluentValidation;

namespace Service.Animals.Web.Handlers.MarkerController.CreateMarker;

public class CreateMarkerRequestValidator : AbstractValidator<CreateMarkerRequest>
{
    public CreateMarkerRequestValidator()
    {
        RuleFor(command => command.Latitude)
            .NotNull().WithMessage("Latitude cannot be null.")
            .NotEmpty().WithMessage("Latitude cannot be empty.");
        
        RuleFor(command => command.Longitude)
            .NotNull().WithMessage("Longitude cannot be null.")
            .NotEmpty().WithMessage("Longitude cannot be empty.");
        
        RuleFor(command => command.LocationName)
            .NotNull().WithMessage("LocationName cannot be null.")
            .NotEmpty().WithMessage("LocationName cannot be empty.");
    }
}