using AutoMapper;
using FluentValidation;
using FluentValidation.Results;
using MediatR;
using Microsoft.EntityFrameworkCore;
using snglrtycrvtureofspce.Animal.Data;
using snglrtycrvtureofspce.Animal.ViewModels;

namespace snglrtycrvtureofspce.Animal.Handlers.LocationController.GetLocation;

public class GetLocationHandler(AnimalsDbContext context, IMapperBase mapper) : IRequestHandler<GetLocationRequest,
    GetLocationResponse>
{
    public async Task<GetLocationResponse> Handle(GetLocationRequest request, CancellationToken cancellationToken)
    {
        var location = await context.Locations
            .FirstOrDefaultAsync(u => u.Id == request.Id, cancellationToken: cancellationToken);

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

        var model = mapper.Map<LocationViewModel>(location);

        var response = new GetLocationResponse
        {
            Message = "Location been successfully received",
            StatusCode = StatusCodes.Status200OK,
            Item = model
        };

        return response;
    }
}