using AutoMapper;
using FluentValidation;
using MediatR;
using snglrtycrvtureofspce.Animal.Data;
using snglrtycrvtureofspce.Animal.Data.Entities;
using snglrtycrvtureofspce.Animal.ViewModels;

namespace snglrtycrvtureofspce.Animal.Handlers.LocationController.CreateLocation;

public class CreateLocationHandler(AnimalsDbContext context, IMapperBase mapper, 
    IValidator<CreateLocationRequest> validator) : IRequestHandler<CreateLocationRequest, CreateLocationResponse>
{
    public async Task<CreateLocationResponse> Handle(CreateLocationRequest request, 
        CancellationToken cancellationToken)
    {
        var validationResult = await validator.ValidateAsync(request, cancellationToken);

        if (!validationResult.IsValid)
        {
            throw new ValidationException(validationResult.Errors);
        }

        var location = new LocationEntity
        {
            Id = Guid.NewGuid(),
            Name = request.Name,
            Description = request.Description,
            Latitude = request.Latitude,
            Longitude = request.Longitude
        };

        context.Locations.Add(location);
        await context.SaveChangesAsync(cancellationToken);

        var model = mapper.Map<LocationViewModel>(location);

        var response = new CreateLocationResponse
        {
            Message = "Location have been successfully created",
            StatusCode = StatusCodes.Status201Created,
            Item = model
        };

        return response;
    }
}