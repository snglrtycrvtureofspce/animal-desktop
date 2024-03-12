using FluentValidation;

namespace snglrtycrvtureofspce.Animal.Handlers.MarkerController.UpdateMarker;

public class UpdateMarkerRequestValidator : AbstractValidator<UpdateMarkerRequest>
{
    public UpdateMarkerRequestValidator()
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