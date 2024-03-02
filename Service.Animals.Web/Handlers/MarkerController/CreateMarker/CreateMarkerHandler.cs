using AutoMapper;
using FluentValidation;
using MediatR;
using Service.Animals.Web.Data;
using Service.Animals.Web.Data.Entities;
using Service.Animals.Web.ViewModels;

namespace Service.Animals.Web.Handlers.MarkerController.CreateMarker;

public class CreateMarkerHandler(AnimalsDbContext context, IMapperBase mapper, 
    IValidator<CreateMarkerRequest> validator) : IRequestHandler<CreateMarkerRequest, CreateMarkerResponse>
{
    public async Task<CreateMarkerResponse> Handle(CreateMarkerRequest request, CancellationToken cancellationToken)
    {
        var validationResult = await validator.ValidateAsync(request, cancellationToken);

        if (!validationResult.IsValid)
        {
            throw new ValidationException(validationResult.Errors);
        }
        
        var marker = new MarkerEntity
        {
            Id = Guid.NewGuid(),
            Latitude = request.Latitude,
            Longitude = request.Longitude,
            LocationName = request.LocationName
        };

        context.Markers.Add(marker);
        await context.SaveChangesAsync(cancellationToken);

        var model = mapper.Map<MarkerViewModel>(marker);
        
        var response = new CreateMarkerResponse
        {
            Message = "Marker have been successfully created",
            StatusCode = StatusCodes.Status201Created,
            Item = model
        };

        return response;
    }
}