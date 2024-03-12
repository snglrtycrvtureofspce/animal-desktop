using AutoMapper;
using FluentValidation;
using FluentValidation.Results;
using MediatR;
using Microsoft.EntityFrameworkCore;
using snglrtycrvtureofspce.Animal.Data;
using snglrtycrvtureofspce.Animal.ViewModels;

namespace snglrtycrvtureofspce.Animal.Handlers.LocationController.UpdateLocation;

public class UpdateLocationHandler(AnimalsDbContext context, IMapperBase mapper, 
    IValidator<UpdateLocationRequest> validator) : IRequestHandler<UpdateLocationRequest, UpdateLocationResponse>
{
    public async Task<UpdateLocationResponse> Handle(UpdateLocationRequest request, 
        CancellationToken cancellationToken)
    {
        var validationResult = await validator.ValidateAsync(request, cancellationToken);

        if (!validationResult.IsValid)
        {
            throw new ValidationException(validationResult.Errors);
        }

        var location = await context.Locations
            .FirstOrDefaultAsync(i => i.Id == request.Id, cancellationToken: cancellationToken);

        if (location == null)
        {
            throw new ValidationException("Location not found",
                new List<ValidationFailure>
                {
                    new()
                    {
                        PropertyName = nameof(request.Id),
                        ErrorMessage = "Location not found",
                        ErrorCode = StatusCodes.Status404NotFound.ToString()
                    }
                });
        }

        location.Name = request.Name;
        location.Description = request.Description;
        location.Latitude = request.Latitude;
        location.Longitude = request.Longitude;

        await context.SaveChangesAsync(cancellationToken);

        var model = mapper.Map<LocationViewModel>(location);

        var response = new UpdateLocationResponse
        {
            Message = "Location have been successfully updated",
            StatusCode = StatusCodes.Status200OK,
            Item = model
        };

        return response;
    }
}