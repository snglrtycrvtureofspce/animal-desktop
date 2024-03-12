using MediatR;

namespace snglrtycrvtureofspce.Animal.Handlers.LocationController.GetLocation;

public class GetLocationRequest : IRequest<GetLocationResponse>
{
    public Guid Id { get; set; }
}