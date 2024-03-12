using AutoMapper;
using FluentValidation;
using FluentValidation.Results;
using MediatR;
using Microsoft.EntityFrameworkCore;
using snglrtycrvtureofspce.Animal.Data;
using snglrtycrvtureofspce.Animal.ViewModels;

namespace snglrtycrvtureofspce.Animal.Handlers.MarkerController.UpdateMarker;

public class UpdateMarkerHandler(
    AnimalsDbContext context,
    IMapperBase mapper,
    IValidator<UpdateMarkerRequest> validator) : IRequestHandler<UpdateMarkerRequest, UpdateMarkerResponse>
{
    public async Task<UpdateMarkerResponse> Handle(UpdateMarkerRequest request,
        CancellationToken cancellationToken)
    {
        var validationResult = await validator.ValidateAsync(request, cancellationToken);

        if (!validationResult.IsValid)
        {
            throw new ValidationException(validationResult.Errors);
        }

        var animal = await context.Markers.FirstOrDefaultAsync(i => i.Id == request.Id,
            cancellationToken: cancellationToken);

        if (animal == null)
        {
            throw new ValidationException("Marker not found",
                new List<ValidationFailure>
                {
                    new()
                    {
                        PropertyName = nameof(request.Id),
                        ErrorMessage = "Marker not found",
                        ErrorCode = StatusCodes.Status404NotFound.ToString()
                    }
                });
        }

        animal.Latitude = request.Latitude;
        animal.Longitude = request.Longitude;
        animal.LocationName = request.LocationName;

        await context.SaveChangesAsync(cancellationToken);

        var model = mapper.Map<MarkerViewModel>(animal);

        var response = new UpdateMarkerResponse
        {
            Message = "Marker have been successfully updated",
            StatusCode = StatusCodes.Status200OK,
            Item = model
        };

        return response;
    }
}