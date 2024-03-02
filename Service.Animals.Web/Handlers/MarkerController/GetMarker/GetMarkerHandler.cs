using AutoMapper;
using FluentValidation;
using FluentValidation.Results;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Service.Animals.Web.Data;
using Service.Animals.Web.ViewModels;

namespace Service.Animals.Web.Handlers.MarkerController.GetMarker;

public class GetMarkerHandler(AnimalsDbContext context, IMapperBase mapper) : IRequestHandler<GetMarkerRequest, 
    GetMarkerResponse>
{
    public async Task<GetMarkerResponse> Handle(GetMarkerRequest request, CancellationToken cancellationToken)
    {
        var marker = await context.Markers.FirstOrDefaultAsync(u => u.Id == request.Id, 
            cancellationToken: cancellationToken);

        if (marker == null)
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

        var model = mapper.Map<MarkerViewModel>(marker);

        var response = new GetMarkerResponse
        {
            Message = "Marker have been successfully received",
            StatusCode = StatusCodes.Status200OK,
            Item = model
        };

        return response;
    }
}